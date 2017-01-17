--[[
	需要3个参数
	1、资源路径
	2、保存的路径
	cfg_db.lua文件(被require进来)(db导出配置文件)

	导出后会在保存目录生成一个叫CfgFiles.lua的文件列表，包含所有cfg文件名
--]]
local len = #arg

if len < 3 then
	print(string.format( "arg len need 3, but %s", len ))
	return
else
	-- print( string.format( "RES_PATH:%s\nSAVE_PATH:%s\nDB_CFG:%s", arg[1], arg[2], arg[3] ) )
end

------ 解析参数 ------
RES_PATH = arg[1]:gsub("\\", "/")
if RES_PATH:sub(-1) ~= "" then RES_PATH = RES_PATH.."/" end
SAVE_PATH = arg[2]:gsub("\\", "/")
if SAVE_PATH:sub(-1) ~= "" then SAVE_PATH = SAVE_PATH.."/" end
DB_CFG = arg[3]:gsub("\\", "/")


------ 处理luapath ------
package.path = package.path..";./?.lua"..";../?.lua"
package.path = package.path..(string.format(";%s?.lua;", RES_PATH))


------ 加载依赖库 ------
local CfgParser = require("CfgParser")
require("saveTable")
local CSClass = require("CSClass")


------ 加载cfg_db ------
local dbCfg = require(DB_CFG)
if not dbCfg then
	print( string.format( "can't find file dbCfg in %s", DB_CFG ) )
	return
end


------ 解析数据 ------
local allDatas = {}
for file, cfg in pairs( dbCfg ) do
	allDatas[file] = CfgParser.parseFileWithFormater( file, cfg.mode, cfg.formater )
end


------ 保存解析table，覆盖原文件 ------
local fileNames = {}
for file, data in pairs( allDatas ) do
	SaveTable( data, string.format( "%s%s.lua", SAVE_PATH, file ) )
	table.insert( fileNames, file )
end


------ 保存文件列表 ------
-- 保证顺序
table.sort( fileNames )
SaveTable( fileNames, string.format( "%s%s.lua", SAVE_PATH, "CfgFiles" ) )


xpcall(
	function ()
		------ 导出CS数据结构
		local CS_PATH = "../../Assets/wumai/Scripts/Data/"

		local dbLoader = CSClass.New()

		dbLoader:addClassName("DbLoader")
		dbLoader:addUsing("LuaFramework")
		dbLoader:addUsing("LuaInterface")
		dbLoader:addCustom("private static bool m_bInited = false;")
		dbLoader:addCustom("public delegate DbBase CreateDbItem();")
		dbLoader:startFunction("private static void callInit<T>(LuaFunction initFunc, string name) where T : DbBase, new()")
		dbLoader:addFuncContent("CreateDbItem createFunc = () =>{return new T();};")
		dbLoader:addFuncContent("initFunc.Call(name, createFunc);")
		dbLoader:endFunction()

		dbLoader:startFunction("public static void init()")
		dbLoader:addFuncContent("if(m_bInited) return;")
		dbLoader:addFuncContent("var mgr = AppFacade.Instance.GetManager<LuaManager>(ManagerName.Lua);")
		dbLoader:addFuncContent("var tb = mgr.DoFile(\"Game/Common/DbLoader\")[0] as LuaTable;")
		dbLoader:addFuncContent("var luaInitFunc = tb[\"init\"] as LuaFunction;\n")


		for name, _ in pairs(dbCfg) do
			
			package.preload[name] = nil
			package.loaded[name] = nil
			data = require(name)

			dbLoader:addFuncContent(string.format("callInit<%s>(luaInitFunc, \"%s\");", name, name))

			local types, fields = data.types, data.fields

			local cs = CSClass.New()
			-- cs:addNameSpace("Game")
			cs:addClassName(string.format("%s : DbBase", name))
			cs:addUsing("LuaInterface")
			cs:addUsing("System.Collections.Generic")
			cs:addCustom(string.format("private static Dictionary<int, %s> m_allData = new Dictionary<int,%s>();", name, name))

			cs:startFunction("public override void init(int a, LuaTable data)")

			local key
			for idx, fType in ipairs(types) do
				key = fields[idx]
				if fType == "S" then
					cs:addStringField(key)
					cs:addFuncContent(string.format("%s = (string)data[\"%s\"];", key, key))
				elseif fType == "I" then
					cs:addIntField(key)
					cs:addFuncContent(string.format("%s = (int)data[\"%s\"];", key, key))
				elseif fType == "F" then
					cs:addFloatField(key)
					cs:addFuncContent(string.format("%s = (float)data[\"%s\"];", key, key))
				elseif fType == "B" then
					cs:addBoolField(key)
					cs:addFuncContent(string.format("%s = (bool)data[\"%s\"];", key, key))
				else
					print(string.format("can't find type %s by key %s", fType, key))
				end
			end

			cs:endFunction()

    		cs:startFunction(string.format("public static %s get(int key)", name))
    		cs:addFuncContent(string.format("%s db;", name))
    		cs:addFuncContent("m_allData.TryGetValue(key, out db);")
    		cs:addFuncContent("return db;")
    		cs:endFunction()


			cs:save(CS_PATH .. name .. ".cs")
		end
    	
    	dbLoader:addFuncContent("")
    	dbLoader:addFuncContent("m_bInited = true;")
    	dbLoader:endFunction()
    	dbLoader:save(CS_PATH .. "DbLoader" .. ".cs")
	end,
	function (e)
		print(e, debug.traceback())
		os.execute("pause")
	end
)



print( "======> save complete! <======" )



-- daimao={name="cat",niu = false, age=2,body={eyes="green",mouth="big"}}
-- table.save(daimao, "test2.lua")
-- SaveTable(daimao, "test3.lua")