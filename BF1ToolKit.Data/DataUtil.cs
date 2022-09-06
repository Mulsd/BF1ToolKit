using BF1ToolKit.Data.Client;

namespace BF1ToolKit.Data;

public static class DataUtil
{
    /// <summary>
    /// 获取地图对应中文名称
    /// </summary>
    /// <param name="originMapName"></param>
    /// <returns></returns>
    public static string GetMapChsName(string originMapName)
    {
        var index = MapData.AllMapInfo.FindIndex(var => var.English == originMapName);
        if (index != -1)
            return MapData.AllMapInfo[index].Chinese;
        else
            return originMapName;
    }

    /// <summary>
    /// 获取地图对应预览图
    /// </summary>
    /// <param name="originMapName"></param>
    /// <returns></returns>
    public static string GetMapPrevImage(string originMapName)
    {
        var index = MapData.AllMapInfo.FindIndex(var => var.English == originMapName);
        if (index != -1)
            return MapData.AllMapInfo[index].Image;
        else
            return string.Empty;
    }

    /// <summary>
    /// 获取武器对应中文名称
    /// </summary>
    /// <param name="originWeaponName"></param>
    /// <returns></returns>
    public static string GetWeaponChsName(string originWeaponName)
    {
        if (string.IsNullOrEmpty(originWeaponName))
            return string.Empty;

        if (originWeaponName.Contains("_KBullet"))
            return "K 弹";

        if (originWeaponName.Contains("_RGL_Frag"))
            return "步枪手榴弹（破片）";

        if (originWeaponName.Contains("_RGL_Smoke"))
            return "步枪手榴弹（烟雾）";

        if (originWeaponName.Contains("_RGL_HE"))
            return "步枪手榴弹（高爆）";

        int index = WeaponData.AllWeaponInfo.FindIndex(var => var.English == originWeaponName);
        if (index != -1)
            return WeaponData.AllWeaponInfo[index].Chinese;
        else
            return originWeaponName;
    }

    /// <summary>
    /// 获取本地图片路径，如果未找到会返回空字符串
    /// </summary>
    /// <param name="url"></param>
    /// <param name="type"></param>
    /// <returns></returns>
    public static string GetTempImagePath(string url, string type)
    {
        var extension = Path.GetFileName(url);
        switch (type)
        {
            case "maps":
                return ImageData.MapsDict.ContainsKey(extension) ? ImageData.MapsDict[extension] : string.Empty;
            case "weapons":
                return ImageData.WeaponsDict.ContainsKey(extension) ? ImageData.WeaponsDict[extension] : string.Empty;
            case "weapons2":
                return ImageData.Weapons2Dict.ContainsKey(extension) ? ImageData.Weapons2Dict[extension] : string.Empty;
            case "vehicles":
                return ImageData.VehiclesDict.ContainsKey(extension) ? ImageData.VehiclesDict[extension] : string.Empty;
            case "vehicles2":
                return ImageData.Vehicles2Dict.ContainsKey(extension) ? ImageData.Vehicles2Dict[extension] : string.Empty;
            case "classes":
                return ImageData.ClassesDict.ContainsKey(extension) ? ImageData.ClassesDict[extension] : string.Empty;
            case "classes2":
                return ImageData.Classes2Dict.ContainsKey(extension) ? ImageData.Classes2Dict[extension] : string.Empty;
            default:
                return string.Empty;
        }
    }

    /// <summary>
    /// 获取武器简短名称，用于踢人理由
    /// </summary>
    /// <param name="weaponName"></param>
    /// <returns></returns>
    public static string GetWeaponShortTxt(string weaponName)
    {
        int index = WeaponData.AllWeaponInfo.FindIndex(var => var.English.Equals(weaponName));
        if (index != -1)
        {
            return WeaponData.AllWeaponInfo[index].ShortTxt;
        }

        return weaponName;
    }

    /// <summary>
    /// 获取小队的中文名称
    /// </summary>
    /// <param name="squadID"></param>
    /// <returns></returns>
    public static string GetSquadChsName(int squadID)
    {
        switch (squadID)
        {
            case 0:
                return "无";
            case 1:
                return "苹果";
            case 2:
                return "奶油";
            case 3:
                return "查理";
            case 4:
                return "达夫";
            case 5:
                return "爱德华";
            case 6:
                return "弗莱迪";
            case 7:
                return "乔治";
            case 8:
                return "哈利";
            case 9:
                return "墨水";
            case 10:
                return "强尼";
            case 11:
                return "国王";
            case 12:
                return "伦敦";
            case 13:
                return "猿猴";
            case 14:
                return "疯子";
            case 15:
                return "橘子";
            default:
                return squadID.ToString();
        }
    }

    /// <summary>
    /// 获取队伍阵营图片路径
    /// </summary>
    /// <param name="mapName"></param>
    /// <param name="team1Path"></param>
    /// <param name="team2Path"></param>
    public static void GetTeamImage(string mapName, out string team1Path, out string team2Path)
    {
        team1Path = team2Path = string.Empty;

        var index = MapData.AllMapInfo.FindIndex(var => var.English.Equals(mapName));
        if (index != -1 && mapName != "ID_M_LEVEL_MENU")
        {
            team1Path = $"\\Assets\\Images\\Client\\Teams\\{MapData.AllMapInfo[index].Team1}.png";
            team2Path = $"\\Assets\\Images\\Client\\Teams\\{MapData.AllMapInfo[index].Team2}.png";
        }
        else
        {
            team1Path = team2Path = "\\Assets\\Images\\Client\\Teams\\_DEF.png";
        }
    }

    /// <summary>
    /// 获取当前地图游戏模式
    /// </summary>
    /// <param name="modeName"></param>
    /// <returns></returns>
    public static string GetGameMode(string modeName)
    {
        var index = ModeData.AllModeInfo.FindIndex(var => var.Mark.Equals(modeName));
        if (index != -1)
            return ModeData.AllModeInfo[index].Chinese;
        else
            return string.Empty;
    }
}
