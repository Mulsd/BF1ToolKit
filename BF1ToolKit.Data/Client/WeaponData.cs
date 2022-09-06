namespace BF1ToolKit.Data.Client;

public static class WeaponData
{
    public struct WeaponName
    {
        public string Class;
        public string English;
        public string Chinese;
        public string ShortTxt;
    }

    /// <summary>
    /// 全部武器信息，ShortTxt不超过16个字符
    /// </summary>
    public readonly static List<WeaponName> AllWeaponInfo = new()
    {
        // 配枪
        new WeaponName(){ Class="公用配枪", English="U_M1911", Chinese="M1911", ShortTxt="M1911" },
        new WeaponName(){ Class="公用配枪", English="U_LugerP08", Chinese="P08 手枪", ShortTxt="P08" },
        new WeaponName(){ Class="公用配枪", English="U_FN1903", Chinese="Mle 1903", ShortTxt="M1903" },
        new WeaponName(){ Class="公用配枪", English="U_BorchardtC93", Chinese="C93", ShortTxt="C93" },
        new WeaponName(){ Class="公用配枪", English="U_SmithWesson", Chinese="3 号左轮手枪", ShortTxt="No3 Rev" },
        new WeaponName(){ Class="公用配枪", English="U_Kolibri", Chinese="Kolibri", ShortTxt="Kolibri" },
        new WeaponName(){ Class="公用配枪", English="U_NagantM1895", Chinese="纳甘左轮手枪", ShortTxt="Nagant Rev" },
        new WeaponName(){ Class="公用配枪", English="U_Obrez", Chinese="Obrez 手枪", ShortTxt="Obrez" },
        new WeaponName(){ Class="公用配枪", English="U_Webley_Mk6", Chinese="Mk VI 左轮手枪", ShortTxt="Mk VI" },
        new WeaponName(){ Class="公用配枪", English="U_M1911_Preorder_Hellfighter", Chinese="地狱战士 M1911", ShortTxt="M1911 HF" },
        new WeaponName(){ Class="公用配枪", English="U_LugerP08_Wep_Preorder", Chinese="红男爵的 P08", ShortTxt="P08 HNJ" },
        new WeaponName(){ Class="公用配枪", English="U_M1911_Suppressed", Chinese="M1911（消音器）", ShortTxt="M1911 XYQ" },
        new WeaponName(){ Class="公用配枪", English="U_SingleActionArmy", Chinese="维和左轮 Peacekeeper", ShortTxt="Peacekeeper" },

        // 手榴弹
        new WeaponName(){ Class="手榴弹", English="U_FragGrenade", Chinese="棒式手榴弹", ShortTxt="Frag Grenade" },
        new WeaponName(){ Class="手榴弹", English="U_GermanStick", Chinese="破片手榴弹", ShortTxt="German Stick" },
        new WeaponName(){ Class="手榴弹", English="U_GasGrenade", Chinese="毒气手榴弹", ShortTxt="Gas Grenade" },
        new WeaponName(){ Class="手榴弹", English="U_ImpactGrenade", Chinese="衝击手榴弹", ShortTxt="Impact Grenade" },
        new WeaponName(){ Class="手榴弹", English="U_Incendiary", Chinese="燃烧手榴弹", ShortTxt="Incendiary" },
        new WeaponName(){ Class="手榴弹", English="U_MiniGrenade", Chinese="小型手榴弹", ShortTxt="Mini Grenade" },
        new WeaponName(){ Class="手榴弹", English="U_SmokeGrenade", Chinese="烟雾手榴弹", ShortTxt="Smoke Grenade" },
        new WeaponName(){ Class="手榴弹", English="U_Grenade_AT", Chinese="轻型反坦克手榴弹", ShortTxt="Grenade AT" },
        new WeaponName(){ Class="手榴弹", English="U_ImprovisedGrenade", Chinese="土制手榴弹", ShortTxt="Imsp Grenade" },
        new WeaponName(){ Class="手榴弹", English="U_RussianBox", Chinese="俄罗斯标准手榴弹", ShortTxt="Russian Box" },

        ////////////////////////////////// 突击兵 Assault //////////////////////////////////

        // 突击兵 主要武器
        new WeaponName(){ Class="突击兵 主要武器", English="U_RemingtonM10_Wep_Slug", Chinese="Model 10-A（霰弹块）", ShortTxt="10A XDK" },
        new WeaponName(){ Class="突击兵 主要武器", English="U_RemingtonM10_Wep_Choke", Chinese="Model 10-A（猎人）", ShortTxt="10A LR" },
        new WeaponName(){ Class="突击兵 主要武器", English="U_RemingtonM10", Chinese="Model 10-A（原厂）", ShortTxt="10A YC" },
        new WeaponName(){ Class="突击兵 主要武器", English="U_Winchester1897_Wep_Sweeper", Chinese="M97 战壕枪（扫荡）", ShortTxt="M97 SD" },
        new WeaponName(){ Class="突击兵 主要武器", English="U_Winchester1897_Wep_LowRecoil", Chinese="M97 战壕枪（Back-Bored）", ShortTxt="M97 BB" },
        new WeaponName(){ Class="突击兵 主要武器", English="U_Winchester1897_Wep_Choke", Chinese="M97 战壕枪（猎人）", ShortTxt="M97 LR" },
        new WeaponName(){ Class="突击兵 主要武器", English="U_MP18_Wep_Trench", Chinese="MP 18（壕沟战）", ShortTxt="MP18 HGZ" },
        new WeaponName(){ Class="突击兵 主要武器", English="U_MP18_Wep_Burst", Chinese="MP 18（实验）", ShortTxt="MP18 SY" },
        new WeaponName(){ Class="突击兵 主要武器", English="U_MP18_Wep_Accuracy", Chinese="MP 18（瞄准镜）", ShortTxt="MP18 MZJ" },
        new WeaponName(){ Class="突击兵 主要武器", English="U_BerettaM1918_Wep_Trench", Chinese="M1918 自动衝锋枪（壕沟战）", ShortTxt="MP1918 HGZ" },
        new WeaponName(){ Class="突击兵 主要武器", English="U_BerettaM1918_Wep_Stability", Chinese="M1918 自动衝锋枪（衝锋）", ShortTxt="MP1918 CF" },
        new WeaponName(){ Class="突击兵 主要武器", English="U_BerettaM1918", Chinese="M1918 自动衝锋枪（原厂）", ShortTxt="MP1918 YC" },
        new WeaponName(){ Class="突击兵 主要武器", English="U_BrowningA5_Wep_LowRecoil", Chinese="12g 自动霰弹枪（Back-Bored）", ShortTxt="12g BB" },
        new WeaponName(){ Class="突击兵 主要武器", English="U_BrowningA5_Wep_Choke", Chinese="12g 自动霰弹枪（猎人）", ShortTxt="12g LR" },
        new WeaponName(){ Class="突击兵 主要武器", English="U_BrowningA5_Wep_ExtensionTube", Chinese="12g 自动霰弹枪（加长）", ShortTxt="12g JC" },
        new WeaponName(){ Class="突击兵 主要武器", English="U_Hellriegel1915", Chinese="Hellriegel 1915（原厂）", ShortTxt="H1915 YC" },
        new WeaponName(){ Class="突击兵 主要武器", English="U_Hellriegel1915_Wep_Accuracy", Chinese="Hellriegel 1915（防御）", ShortTxt="H1915 FY" },
        new WeaponName(){ Class="突击兵 主要武器", English="U_Winchester1897_Wep_Preorder", Chinese="地狱战士战壕霰弹枪", ShortTxt="M97 DYZS" },
        new WeaponName(){ Class="突击兵 主要武器", English="U_SjogrenShotgun", Chinese="Sjögren Inertial（原厂）", ShortTxt="RDP YC" },
        new WeaponName(){ Class="突击兵 主要武器", English="U_SjogrenShotgun_Wep_Slug", Chinese="Sjögren Inertial（霰弹块）", ShortTxt="RDP XDK" },
        new WeaponName(){ Class="突击兵 主要武器", English="U_Ribeyrolles", Chinese="利贝罗勒 1918（原厂）", ShortTxt="L1918 YC" },
        new WeaponName(){ Class="突击兵 主要武器", English="U_Ribeyrolles_Wep_Optical", Chinese="Ribeyrolles 1918（瞄准镜）", ShortTxt="L1918 MZJ" },
        new WeaponName(){ Class="突击兵 主要武器", English="U_RemingtonModel1900", Chinese="Model 1900（原厂）", ShortTxt="M1900 YC" },
        new WeaponName(){ Class="突击兵 主要武器", English="U_RemingtonModel1900_Wep_Slug", Chinese="Model 1900（霰弹块）", ShortTxt="M1900 XDK" },
        new WeaponName(){ Class="突击兵 主要武器", English="U_MaximSMG", Chinese="SMG 08/18（原厂）", ShortTxt="SMG0818 YC" },
        new WeaponName(){ Class="突击兵 主要武器", English="U_MaximSMG_Wep_Accuracy", Chinese="SMG 08/18（瞄准镜）", ShortTxt="SMG0818 MZJ" },
        new WeaponName(){ Class="突击兵 主要武器", English="U_SteyrM1912_P16", Chinese="M1912/P.16（衝锋）", ShortTxt="M1912 P.16 CF" },
        new WeaponName(){ Class="突击兵 主要武器", English="U_SteyrM1912_P16_Wep_Burst", Chinese="Maschinenpistole M1912/P.16（实验）", ShortTxt="M1912 P.16 SY" },
        new WeaponName(){ Class="突击兵 主要武器", English="U_Mauser1917Trench", Chinese="M1917 战壕卡宾枪", ShortTxt="M1917 KBQ ZH" },
        new WeaponName(){ Class="突击兵 主要武器", English="U_Mauser1917Trench_Wep_Scope", Chinese="M1917 卡宾枪（巡逻）", ShortTxt="M1917 KBQ XL" },
        new WeaponName(){ Class="突击兵 主要武器", English="U_ChauchatSMG", Chinese="RSC 衝锋枪（原厂）", ShortTxt="RSC YC" },
        new WeaponName(){ Class="突击兵 主要武器", English="U_ChauchatSMG_Wep_Optical", Chinese="RSC 衝锋枪（瞄准镜）", ShortTxt="RSC MZJ" },
        new WeaponName(){ Class="突击兵 主要武器", English="U_M1919Thompson_Wep_Trench", Chinese="Annihilator（壕沟）", ShortTxt="Annihilator HG" },
        new WeaponName(){ Class="突击兵 主要武器", English="U_M1919Thompson_Wep_Stability", Chinese="Annihilator（衝锋）", ShortTxt="Annihilator CF" },
        new WeaponName(){ Class="突击兵 主要武器", English="U_FrommerStopAuto", Chinese="费罗梅尔停止手枪（自动）", ShortTxt="FrommerStopAuto" },
        new WeaponName(){ Class="突击兵 主要武器", English="U_SawnOffShotgun", Chinese="短管霰弹枪", ShortTxt="SawnOffShotgun" },

        // 突击兵 配枪
        new WeaponName(){ Class="突击兵 配枪", English="U_GasserM1870", Chinese="加塞 M1870", ShortTxt="M1870" },
        new WeaponName(){ Class="突击兵 配枪", English="U_LancasterHowdah", Chinese="Howdah 手枪", ShortTxt="Howdah" },
        new WeaponName(){ Class="突击兵 配枪", English="U_Hammerless", Chinese="1903 Hammerless", ShortTxt="1903" },

        // 突击兵 配备一二
        new WeaponName(){ Class="突击兵 配备一二", English="U_Dynamite", Chinese="炸药", ShortTxt="Dynamite" },
        new WeaponName(){ Class="突击兵 配备一二", English="U_ATGrenade", Chinese="反坦克手榴弹", ShortTxt="ATGrenade" },
        new WeaponName(){ Class="突击兵 配备一二", English="U_ATMine", Chinese="反坦克地雷", ShortTxt="ATMine" },
        new WeaponName(){ Class="突击兵 配备一二", English="U_BreechGun", Chinese="反坦克火箭砲", ShortTxt="AT" },
        new WeaponName(){ Class="突击兵 配备一二", English="U_BreechGun_Flak", Chinese="防空火箭砲", ShortTxt="AAT" },

        ////////////////////////////////// 医疗兵 Medic   //////////////////////////////////

        // 医疗兵 主要武器
        new WeaponName(){ Class="医疗兵 主要武器", English="U_CeiRigottiM1895_Wep_Trench", Chinese="Cei-Rigotti（壕沟战）", ShortTxt="M1895 HGZ" },
        new WeaponName(){ Class="医疗兵 主要武器", English="U_CeiRigottiM1895_Wep_Range", Chinese="Cei-Rigotti（瞄准镜）", ShortTxt="M1895 MZJ" },
        new WeaponName(){ Class="医疗兵 主要武器", English="U_CeiRigottiM1895", Chinese="Cei-Rigotti（原厂）", ShortTxt="M1895 YC" },
        new WeaponName(){ Class="医疗兵 主要武器", English="U_MauserSL1916_Wep_Scope", Chinese="Selbstlader M1916（神射手）", ShortTxt="M1916 SSS" },
        new WeaponName(){ Class="医疗兵 主要武器", English="U_MauserSL1916_Wep_Range", Chinese="Selbstlader M1916（瞄准镜）", ShortTxt="M1916 MZJ" },
        new WeaponName(){ Class="医疗兵 主要武器", English="U_MauserSL1916", Chinese="Selbstlader M1916（原厂）", ShortTxt="M1916 YC" },
        new WeaponName(){ Class="医疗兵 主要武器", English="U_WinchesterM1907_Wep_Trench", Chinese="M1907 半自动步枪（壕沟战）", ShortTxt="M1907 JGZ" },
        new WeaponName(){ Class="医疗兵 主要武器", English="U_WinchesterM1907_Wep_Auto", Chinese="M1907 半自动步枪（扫荡）", ShortTxt="M1907 SD" },
        new WeaponName(){ Class="医疗兵 主要武器", English="U_WinchesterM1907", Chinese="M1907 半自动步枪（原厂）", ShortTxt="M1907 YC" },
        new WeaponName(){ Class="医疗兵 主要武器", English="U_Mondragon_Wep_Range", Chinese="蒙德拉贡步枪（瞄准镜）", ShortTxt="Mondragon MZJ" },
        new WeaponName(){ Class="医疗兵 主要武器", English="U_Mondragon_Wep_Stability", Chinese="蒙德拉贡步枪（衝锋）", ShortTxt="Mondragon CF" },
        new WeaponName(){ Class="医疗兵 主要武器", English="U_Mondragon_Wep_Bipod", Chinese="蒙德拉贡步枪（狙击手）", ShortTxt="Mondragon JJS" },
        new WeaponName(){ Class="医疗兵 主要武器", English="U_RemingtonModel8", Chinese="自动装填步枪 8.35（原厂）", ShortTxt="8.35 YC" },
        new WeaponName(){ Class="医疗兵 主要武器", English="U_RemingtonModel8_Wep_Scope", Chinese="自动装填步枪 8.35（神射手）", ShortTxt="8.35 SSS" },
        new WeaponName(){ Class="医疗兵 主要武器", English="U_RemingtonModel8_Wep_ExtendedMag", Chinese="自动装填步枪 8.25（加长）", ShortTxt="8.25 JC" },
        new WeaponName(){ Class="医疗兵 主要武器", English="U_Luger1906", Chinese="Selbstlader 1906（原厂）", ShortTxt="1906 YC" },
        new WeaponName(){ Class="医疗兵 主要武器", English="U_Luger1906_Wep_Scope", Chinese="Selbstlader 1906（狙击手）", ShortTxt="1906 JJS" },
        new WeaponName(){ Class="医疗兵 主要武器", English="U_RSC1917_Wep_Range", Chinese="RSC 1917（瞄准镜）", ShortTxt="RSC 1917 MZJ" },
        new WeaponName(){ Class="医疗兵 主要武器", English="U_RSC1917", Chinese="RSC 1917（原厂）", ShortTxt="RSC 1917 YC" },
        new WeaponName(){ Class="医疗兵 主要武器", English="U_FedorovAvtomat_Wep_Trench", Chinese="费德洛夫自动步枪（壕沟战）", ShortTxt="Fedorov HGZ" },
        new WeaponName(){ Class="医疗兵 主要武器", English="U_FedorovAvtomat_Wep_Range", Chinese="费德洛夫自动步枪（瞄准镜）", ShortTxt="Fedorov MZJ" },
        new WeaponName(){ Class="医疗兵 主要武器", English="U_GeneralLiuRifle", Chinese="刘将军步枪（原厂）", ShortTxt="GeneralLiu YC" },
        new WeaponName(){ Class="医疗兵 主要武器", English="U_GeneralLiuRifle_Wep_Stability", Chinese="刘将军步枪（衝锋）", ShortTxt="GeneralLiu CF" },
        new WeaponName(){ Class="医疗兵 主要武器", English="U_FarquharHill_Wep_Range", Chinese="Farquhar-Hill 步枪（瞄准镜）", ShortTxt="Farquhar MZJ" },
        new WeaponName(){ Class="医疗兵 主要武器", English="U_FarquharHill_Wep_Stability", Chinese="Farquhar-Hill 步枪（衝锋）", ShortTxt="Farquhar CF" },
        new WeaponName(){ Class="医疗兵 主要武器", English="U_BSAHowellM1916", Chinese="Howell 自动步枪（原厂）", ShortTxt="Howell YC" },
        new WeaponName(){ Class="医疗兵 主要武器", English="U_BSAHowellM1916_Wep_Scope", Chinese="Howell 自动步枪（狙击手）", ShortTxt="Howell JJS" },
        new WeaponName(){ Class="医疗兵 主要武器", English="U_FedorovDegtyarev", Chinese="费德洛夫 Degtyarev", ShortTxt="Fedorov SL" },

        // 医疗兵 配枪
        new WeaponName(){ Class="医疗兵 配枪", English="U_WebFosAutoRev_455Webley", Chinese="自动左轮手枪", ShortTxt="Auto Rev" },
        new WeaponName(){ Class="医疗兵 配枪", English="U_MauserC96", Chinese="C96", ShortTxt="C96" },
        new WeaponName(){ Class="医疗兵 配枪", English="U_Mauser1914", Chinese="Taschenpistole M1914", ShortTxt="M1914" },

        // 医疗兵 配备一二
        new WeaponName(){ Class="医疗兵 配备一二", English="U_Syringe", Chinese="医疗用针筒", ShortTxt="Syringe" },
        new WeaponName(){ Class="医疗兵 配备一二", English="U_MedicBag", Chinese="医护箱", ShortTxt="MedicBag" },
        new WeaponName(){ Class="医疗兵 配备一二", English="U_Bandages", Chinese="绷带包", ShortTxt="Bandages" },
        new WeaponName(){ Class="医疗兵 配备一二", English="_RGL_Frag", Chinese="步枪手榴弹（破片）", ShortTxt="RGL Frag" },
        new WeaponName(){ Class="医疗兵 配备一二", English="_RGL_Smoke", Chinese="步枪手榴弹（烟雾）", ShortTxt="RGL Smoke" },
        new WeaponName(){ Class="医疗兵 配备一二", English="_RGL_HE", Chinese="步枪手榴弹（高爆）", ShortTxt="RGL HE" },

        ////////////////////////////////// 支援兵 Support //////////////////////////////////

        // 支援兵 主要武器
        new WeaponName(){ Class="支援兵 主要武器", English="U_LewisMG_Wep_Suppression", Chinese="路易士机枪（压制）", ShortTxt="LewisMG YZ" },
        new WeaponName(){ Class="支援兵 主要武器", English="U_LewisMG_Wep_Range", Chinese="路易士机枪（瞄准镜）", ShortTxt="LewisMG MZJ" },
        new WeaponName(){ Class="支援兵 主要武器", English="U_LewisMG", Chinese="路易士机枪（轻量化）", ShortTxt="LewisMG QLH" },
        new WeaponName(){ Class="支援兵 主要武器", English="U_HotchkissM1909_Wep_Stability", Chinese="M1909 贝内特·梅西耶机枪（衝锋）", ShortTxt="M1909 CF" },
        new WeaponName(){ Class="支援兵 主要武器", English="U_HotchkissM1909_Wep_Range", Chinese="M1909 贝内特·梅西耶机枪（瞄准镜）", ShortTxt="M1909 MZJ" },
        new WeaponName(){ Class="支援兵 主要武器", English="U_HotchkissM1909_Wep_Bipod", Chinese="M1909 贝内特·梅西耶机枪（望远瞄具）", ShortTxt="M1909 WYMJ" },
        new WeaponName(){ Class="支援兵 主要武器", English="U_MadsenMG_Wep_Trench", Chinese="麦德森机枪（壕沟战）", ShortTxt="MadsenMG HGZ" },
        new WeaponName(){ Class="支援兵 主要武器", English="U_MadsenMG_Wep_Stability", Chinese="麦德森机枪（衝锋）", ShortTxt="MadsenMG CF" },
        new WeaponName(){ Class="支援兵 主要武器", English="U_MadsenMG", Chinese="麦德森机枪（轻量化）", ShortTxt="MadsenMG QLH" },
        new WeaponName(){ Class="支援兵 主要武器", English="U_Bergmann1915MG_Wep_Suppression", Chinese="MG15 n.A.（压制）", ShortTxt="MG15 YZ" },
        new WeaponName(){ Class="支援兵 主要武器", English="U_Bergmann1915MG_Wep_Stability", Chinese="MG15 n.A.（衝锋）", ShortTxt="MG15 CF" },
        new WeaponName(){ Class="支援兵 主要武器", English="U_Bergmann1915MG", Chinese="MG15 n.A.（轻量化）", ShortTxt="MG15 QLH" },
        new WeaponName(){ Class="支援兵 主要武器", English="U_BARM1918_Wep_Trench", Chinese="M1918 白朗宁自动步枪（壕沟战）", ShortTxt="M1918 HGZ" },
        new WeaponName(){ Class="支援兵 主要武器", English="U_BARM1918_Wep_Stability", Chinese="M1918 白朗宁自动步枪（衝锋）", ShortTxt="M1918 CF" },
        new WeaponName(){ Class="支援兵 主要武器", English="U_BARM1918_Wep_Bipod", Chinese="M1918 白朗宁自动步枪（望远瞄具）", ShortTxt="M1918 WYMJ" },
        new WeaponName(){ Class="支援兵 主要武器", English="U_HuotAutoRifle", Chinese="Huot 自动步枪（轻量化）", ShortTxt="Huot QLH" },
        new WeaponName(){ Class="支援兵 主要武器", English="U_HuotAutoRifle_Wep_Range", Chinese="Huot 自动步枪（瞄准镜）", ShortTxt="Huot HGZ" },
        new WeaponName(){ Class="支援兵 主要武器", English="U_Chauchat", Chinese="绍沙轻机枪（轻量化）", ShortTxt="Chauchat QLH" },
        new WeaponName(){ Class="支援兵 主要武器", English="U_Chauchat_Wep_Bipod", Chinese="绍沙轻机枪（望远瞄具）", ShortTxt="Chauchat WYMJ" },
        new WeaponName(){ Class="支援兵 主要武器", English="U_ParabellumLMG", Chinese="Parabellum MG14/17（轻量化）", ShortTxt="MG1417 QLH" },
        new WeaponName(){ Class="支援兵 主要武器", English="U_ParabellumLMG_Wep_Suppression", Chinese="Parabellum MG14/17（压制）", ShortTxt="MG1417 YZ" },
        new WeaponName(){ Class="支援兵 主要武器", English="U_PerinoM1908", Chinese="Perino Model 1908（轻量化）", ShortTxt="M1908 QLH" },
        new WeaponName(){ Class="支援兵 主要武器", English="U_PerinoM1908_Wep_Defensive", Chinese="Perino Model 1908（防御）", ShortTxt="M1908 FY" },
        new WeaponName(){ Class="支援兵 主要武器", English="U_BrowningM1917", Chinese="M1917 机枪（轻量化）", ShortTxt="M1917 QLH" },
        new WeaponName(){ Class="支援兵 主要武器", English="U_BrowningM1917_Wep_Suppression", Chinese="M1917 机枪（望远瞄具）", ShortTxt="M1917 WYMJ" },
        new WeaponName(){ Class="支援兵 主要武器", English="U_MG0818", Chinese="轻机枪 08/18（轻量化）", ShortTxt="MG0818 QLH" },
        new WeaponName(){ Class="支援兵 主要武器", English="U_MG0818_Wep_Defensive", Chinese="轻机枪 08/18（压制）", ShortTxt="MG0818 YZ" },
        new WeaponName(){ Class="支援兵 主要武器", English="U_WinchesterBurton_Wep_Trench", Chinese="波顿 LMR（战壕）", ShortTxt="Burton LMR ZH" },
        new WeaponName(){ Class="支援兵 主要武器", English="U_WinchesterBurton_Wep_Optical", Chinese="波顿 LMR（瞄准镜）", ShortTxt="Burton LMR HZJ" },
        new WeaponName(){ Class="支援兵 主要武器", English="U_MauserC96AutoPistol", Chinese="C96（卡宾枪）", ShortTxt="C96 KBQ" },
        new WeaponName(){ Class="支援兵 主要武器", English="U_LugerArtillery", Chinese="P08 Artillerie", ShortTxt="P08 Artillerie" },
        new WeaponName(){ Class="支援兵 主要武器", English="U_PieperCarbine", Chinese="皮珀 M1893", ShortTxt="M1893" },
        new WeaponName(){ Class="支援兵 主要武器", English="U_M1911_Stock", Chinese="M1911（加长）", ShortTxt="M1911 JC" },
        new WeaponName(){ Class="支援兵 主要武器", English="U_FN1903stock", Chinese="Mle 1903（加长）", ShortTxt="Mle 1903 JC" },
        new WeaponName(){ Class="支援兵 主要武器", English="U_C93Carbine", Chinese="C93（卡宾枪）", ShortTxt="C93 KBQ" },

        // 支援兵 配枪
        new WeaponName(){ Class="支援兵 配枪", English="U_SteyrM1912", Chinese="Repetierpistole M1912", ShortTxt="M1912" },
        new WeaponName(){ Class="支援兵 配枪", English="U_Bulldog", Chinese="斗牛犬左轮手枪", ShortTxt="Bulldog" },
        new WeaponName(){ Class="支援兵 配枪", English="U_BerettaM1915", Chinese="Modello 1915", ShortTxt="Modello 1915" },

        // 支援兵 配备一二
        new WeaponName(){ Class="支援兵 配备一二", English="U_AmmoCrate", Chinese="弹药箱", ShortTxt="Ammo Crate" },
        new WeaponName(){ Class="支援兵 配备一二", English="U_AmmoPouch", Chinese="弹药包", ShortTxt="Ammo Pouch" },
        new WeaponName(){ Class="支援兵 配备一二", English="U_Mortar", Chinese="迫击砲（空爆）", ShortTxt="Mortar KB" },
        new WeaponName(){ Class="支援兵 配备一二", English="U_Mortar_HE", Chinese="迫击砲（高爆）", ShortTxt="Mortar GB" },
        new WeaponName(){ Class="支援兵 配备一二", English="U_Wrench", Chinese="维修工具", ShortTxt="Wrench" },
        new WeaponName(){ Class="支援兵 配备一二", English="U_LimpetMine", Chinese="磁吸地雷", ShortTxt="Limpet Mine" },
        new WeaponName(){ Class="支援兵 配备一二", English="U_Crossbow", Chinese="十字弓发射器（破片）", ShortTxt="Crossbow PP" },
        new WeaponName(){ Class="支援兵 配备一二", English="U_Crossbow_HE", Chinese="十字弓发射器（高爆）", ShortTxt="Crossbow GB" },

        ////////////////////////////////// 侦察兵 Scout   //////////////////////////////////

        // 侦察兵 主要武器
        new WeaponName(){ Class="侦察兵 主要武器", English="U_WinchesterM1895_Wep_Trench", Chinese="Russian 1895（壕沟战）", ShortTxt="1895 HGZ" },
        new WeaponName(){ Class="侦察兵 主要武器", English="U_WinchesterM1895_Wep_Long", Chinese="Russian 1895（狙击手）", ShortTxt="1895 JJS" },
        new WeaponName(){ Class="侦察兵 主要武器", English="U_WinchesterM1895", Chinese="Russian 1895（步兵）", ShortTxt="1895 BB" },
        new WeaponName(){ Class="侦察兵 主要武器", English="U_Gewehr98_Wep_Scope", Chinese="Gewehr 98（神射手）", ShortTxt="G98 SSS" },
        new WeaponName(){ Class="侦察兵 主要武器", English="U_Gewehr98_Wep_LongRange", Chinese="Gewehr 98（狙击手）", ShortTxt="G98 JJS" },
        new WeaponName(){ Class="侦察兵 主要武器", English="U_Gewehr98", Chinese="Gewehr 98（步兵）", ShortTxt="G98 BB" },
        new WeaponName(){ Class="侦察兵 主要武器", English="U_LeeEnfieldSMLE_Wep_Scope", Chinese="SMLE MKIII（神射手）", ShortTxt="MKIII SSS" },
        new WeaponName(){ Class="侦察兵 主要武器", English="U_LeeEnfieldSMLE_Wep_Med", Chinese="SMLE MKIII（卡宾枪）", ShortTxt="MKIII KBQ" },
        new WeaponName(){ Class="侦察兵 主要武器", English="U_LeeEnfieldSMLE", Chinese="SMLE MKIII（步兵）", ShortTxt="MKIII BB" },
        new WeaponName(){ Class="侦察兵 主要武器", English="U_SteyrManM1895_Wep_Scope", Chinese="Gewehr M.95（神射手）", ShortTxt="G95 SSS" },
        new WeaponName(){ Class="侦察兵 主要武器", English="U_SteyrManM1895_Wep_Med", Chinese="Gewehr M.95（卡宾枪）", ShortTxt="G95 KBQ" },
        new WeaponName(){ Class="侦察兵 主要武器", English="U_SteyrManM1895", Chinese="Gewehr M.95（步兵）", ShortTxt="G95 BB" },
        new WeaponName(){ Class="侦察兵 主要武器", English="U_SpringfieldM1903_Wep_Scope", Chinese="M1903（神射手）", ShortTxt="M1903 SSS" },
        new WeaponName(){ Class="侦察兵 主要武器", English="U_SpringfieldM1903_Wep_LongRange", Chinese="M1903（狙击手）", ShortTxt="M1903 JJS" },
        new WeaponName(){ Class="侦察兵 主要武器", English="U_SpringfieldM1903_Wep_Pedersen", Chinese="M1903（实验）", ShortTxt="M1903 SY" },
        new WeaponName(){ Class="侦察兵 主要武器", English="U_MartiniHenry", Chinese="马提尼·亨利步枪（步兵）", ShortTxt="MartiniHenry BB" },
        new WeaponName(){ Class="侦察兵 主要武器", English="U_MartiniHenry_Wep_LongRange", Chinese="马提尼·亨利步枪（狙击手）", ShortTxt="MartiniHenry JJS" },
        new WeaponName(){ Class="侦察兵 主要武器", English="U_LeeEnfieldSMLE_Wep_Preorder", Chinese="阿拉伯的劳伦斯的 SMLE", ShortTxt="SMLE LLS" },
        new WeaponName(){ Class="侦察兵 主要武器", English="U_Lebel1886_Wep_LongRange", Chinese="勒贝尔 M1886（狙击手）", ShortTxt="M1886 JJS" },
        new WeaponName(){ Class="侦察兵 主要武器", English="U_Lebel1886", Chinese="勒贝尔 M1886（步兵）", ShortTxt="M1886 BB" },
        new WeaponName(){ Class="侦察兵 主要武器", English="U_MosinNagant1891", Chinese="莫辛-纳甘 M91（步兵）", ShortTxt="M91 BB" },
        new WeaponName(){ Class="侦察兵 主要武器", English="U_MosinNagant1891_Wep_Scope", Chinese="莫辛-纳甘 M91（神射手）", ShortTxt="M91 SSS" },
        new WeaponName(){ Class="侦察兵 主要武器", English="U_VetterliVitaliM1870", Chinese="Vetterli-Vitali M1870/87（步兵）", ShortTxt="M1870 BB" },
        new WeaponName(){ Class="侦察兵 主要武器", English="U_VetterliVitaliM1870_Wep_Med", Chinese="Vetterli-Vitali M1870/87（卡宾枪）", ShortTxt="M1870 KBQ" },
        new WeaponName(){ Class="侦察兵 主要武器", English="U_Type38Arisaka", Chinese="三八式步枪（步兵）", ShortTxt="Type38 BB" },
        new WeaponName(){ Class="侦察兵 主要武器", English="U_Type38Arisaka_Wep_Scope", Chinese="三八式步枪（巡逻）", ShortTxt="Type38 XL" },
        new WeaponName(){ Class="侦察兵 主要武器", English="U_CarcanoCarbine", Chinese="卡尔卡诺 M91 卡宾枪", ShortTxt="M91 KBQ" },
        new WeaponName(){ Class="侦察兵 主要武器", English="U_CarcanoCarbine_Wep_Scope", Chinese="卡尔卡诺 M91 卡宾枪（巡逻）", ShortTxt="M91 KBQ XL" },
        new WeaponName(){ Class="侦察兵 主要武器", English="U_RossMkIII", Chinese="罗斯 MKIII（步兵）", ShortTxt="RossMkIII BB" },
        new WeaponName(){ Class="侦察兵 主要武器", English="U_RossMkIII_Wep_Scope", Chinese="罗斯 MKIII（神射手）", ShortTxt="RossMkIII SSS" },
        new WeaponName(){ Class="侦察兵 主要武器", English="U_Enfield1917", Chinese="M1917 Enfield（步兵）", ShortTxt="M1917 BB" },
        new WeaponName(){ Class="侦察兵 主要武器", English="U_Enfield1917_Wep_LongRange", Chinese="M1917 Enfield（消音器）", ShortTxt="M1917 XYQ" },

        // 侦察兵 配枪
        new WeaponName(){ Class="侦察兵 配枪", English="U_MarsAutoPistol", Chinese="Mars 自动手枪", ShortTxt="MarsAutoPistol" },
        new WeaponName(){ Class="侦察兵 配枪", English="U_Bodeo1889", Chinese="Bodeo 1889", ShortTxt="Bodeo 1889" },
        new WeaponName(){ Class="侦察兵 配枪", English="U_FrommerStop", Chinese="费罗梅尔停止手枪", ShortTxt="Frommer Stop" },

        // 侦察兵 配备一二
        new WeaponName(){ Class="侦察兵 配备一二", English="U_FlareGun", Chinese="信号枪（侦察）", ShortTxt="Flare Gun ZC" },
        new WeaponName(){ Class="侦察兵 配备一二", English="U_FlareGun_Flash", Chinese="信号枪（闪光）", ShortTxt="Flare Gun SG" },
        new WeaponName(){ Class="侦察兵 配备一二", English="U_TrPeriscope", Chinese="战壕潜望镜", ShortTxt="Tr Periscope" },
        new WeaponName(){ Class="侦察兵 配备一二", English="U_Shield", Chinese="狙击手护盾", ShortTxt="Shield" },
        new WeaponName(){ Class="侦察兵 配备一二", English="U_HelmetDecoy", Chinese="狙击手诱饵", ShortTxt="Helmet Decoy" },
        new WeaponName(){ Class="侦察兵 配备一二", English="U_TripWireBomb", Chinese="绊索炸弹（高爆）", ShortTxt="Trip Wire Bomb" },
        new WeaponName(){ Class="侦察兵 配备一二", English="U_TripWireGas", Chinese="绊索炸弹（毒气）", ShortTxt="Trip Wire Gas" },
        new WeaponName(){ Class="侦察兵 配备一二", English="U_TripWireBurn", Chinese="绊索炸弹（燃烧）", ShortTxt="Trip Wire Burn" },
        new WeaponName(){ Class="侦察兵 配备一二", English="_KBullet", Chinese="K 弹", ShortTxt="K Bullet" },

        /////////////////////////////////////////////////////////////////////////////

        // 精英兵
        new WeaponName(){ Class="精英兵", English="U_MaximMG0815", Chinese="哨兵 MG 08/15", ShortTxt="Maxim MG0815" },
        new WeaponName(){ Class="精英兵", English="U_VillarPerosa", Chinese="哨兵 维拉·佩罗萨衝锋枪", ShortTxt="Villar Perosa" },
        new WeaponName(){ Class="精英兵", English="U_FlameThrower", Chinese="喷火兵 Wex", ShortTxt="Wex" },
        new WeaponName(){ Class="精英兵", English="U_Incendiary_Hero", Chinese="燃烧手榴弹", ShortTxt="Incendiary Hero" },
        new WeaponName(){ Class="精英兵", English="U_RoyalClub", Chinese="战壕奇兵 奇兵棒", ShortTxt="Royal Club" },
        new WeaponName(){ Class="精英兵", English="U_MartiniGrenadeLauncher", Chinese="入侵者 马提尼·亨利步枪榴弹发射器", ShortTxt="Martini GL" },
        new WeaponName(){ Class="精英兵", English="U_SawnOffShotgun_FK", Chinese="短管霰弹枪", ShortTxt="SawnOffShotgun" },
        new WeaponName(){ Class="精英兵", English="U_FlareGun_Elite", Chinese="信号枪 — 信号", ShortTxt="FlareGun Elite" },
        new WeaponName(){ Class="精英兵", English="U_SpawnBeacon", Chinese="重生信标", ShortTxt="Spawn Beacon" },
        new WeaponName(){ Class="精英兵", English="U_TankGewehr", Chinese="坦克猎手 Tankgewehr M1918", ShortTxt="Tank Gewehr" },
        new WeaponName(){ Class="精英兵", English="U_TrPeriscope_Elite", Chinese="战壕潜望镜", ShortTxt="Tr Periscope" },
        new WeaponName(){ Class="精英兵", English="U_ATGrenade_VhKit", Chinese="反坦克手榴弹", ShortTxt="AT Grenade" },

        ///////////////////////////////////////////////////////////////////////////////////

        // 载具
        new WeaponName(){ Class="坦克", English="ID_P_VNAME_MARKV", Chinese="巡航 Mark V 巡航坦克", ShortTxt="Mark V" },
        new WeaponName(){ Class="坦克", English="ID_P_VNAME_A7V", Chinese="重型坦克 AV7 重型坦克", ShortTxt="AV7" },
        new WeaponName(){ Class="坦克", English="ID_P_VNAME_FT17", Chinese="轻型坦克 FT-17 轻型坦克", ShortTxt="FT-17" },
        new WeaponName(){ Class="坦克", English="ID_P_VNAME_ARTILLERYTRUCK", Chinese="装甲车 火炮装甲车", ShortTxt="ARTILLERYTRUCK" },
        new WeaponName(){ Class="坦克", English="ID_P_VNAME_STCHAMOND", Chinese="攻击坦克 圣沙蒙", ShortTxt="STCHAMOND" },
        new WeaponName(){ Class="坦克", English="ID_P_VNAME_ASSAULTTRUCK", Chinese="突袭装甲车 朴帝洛夫·加福德", ShortTxt="ASSAULTTRUCK" },

        ////////////////
        
        new WeaponName(){ Class="飞机", English="ID_P_VNAME_HALBERSTADT", Chinese="攻击机 哈尔伯施塔特 CL.II 攻击机", ShortTxt="HALBERSTADT" },
        new WeaponName(){ Class="飞机", English="ID_P_VNAME_RUMPLER", Chinese="攻击机 Rumpler C.I 攻击机", ShortTxt="RUMPLER" },
        new WeaponName(){ Class="飞机", English="ID_P_VNAME_BRISTOL", Chinese="攻击机 布里斯托 F2.B 攻击机", ShortTxt="BRISTOL" },
        new WeaponName(){ Class="飞机", English="ID_P_VNAME_SALMSON", Chinese="攻击机 A.E.F 2-A2 攻击机", ShortTxt="SALMSON" },
        new WeaponName(){ Class="飞机", English="ID_P_VNAME_DH10", Chinese="轰炸机 Airco DH.10 轰炸机", ShortTxt="DH10" },
        new WeaponName(){ Class="飞机", English="ID_P_VNAME_HBG1", Chinese="轰炸机 汉莎·布兰登堡 G.I 轰炸机", ShortTxt="HBG1" },
        new WeaponName(){ Class="飞机", English="ID_P_VNAME_CAPRONI", Chinese="轰炸机 卡普罗尼 CA.5 轰炸机", ShortTxt="CAPRONI" },
        new WeaponName(){ Class="飞机", English="ID_P_VNAME_GOTHA", Chinese="轰炸机 戈塔 G 轰炸机", ShortTxt="GOTHA" },
        new WeaponName(){ Class="飞机", English="ID_P_VNAME_SOPWITH", Chinese="战斗机 索普维斯骆驼式战斗机", ShortTxt="SOPWITH" },
        new WeaponName(){ Class="飞机", English="ID_P_VNAME_ALBATROS", Chinese="战斗机 信天翁 D-III 战斗机", ShortTxt="ALBATROS" },
        new WeaponName(){ Class="飞机", English="ID_P_VNAME_DR1", Chinese="战斗机 DR.1 战斗机", ShortTxt="DR1" },
        new WeaponName(){ Class="飞机", English="ID_P_VNAME_SPAD", Chinese="战斗机 SPAD S XIII 战斗机", ShortTxt="SPAD S XIII" },
        new WeaponName(){ Class="飞机", English="ID_P_VNAME_ILYAMUROMETS", Chinese="重型轰炸机 伊利亚·穆罗梅茨", ShortTxt="ILYAMUROMETS" },
        new WeaponName(){ Class="飞机", English="ID_P_VNAME_ASTRATORRES", Chinese="飞船 C 级飞船", ShortTxt="ASTRATORRES" },

        ////////////////

        new WeaponName(){ Class="船", English="ID_P_VNAME_HMS_LANCE", Chinese="船 L 级驱逐舰", ShortTxt="Mark V" },

        ////////////////
        
        new WeaponName(){ Class="骑兵", English="ID_P_VNAME_HORSE", Chinese="骑兵 战马", ShortTxt="HORSE" },

        ////////////////
        
        new WeaponName(){ Class="驾驶员下车", English="U_WinchesterM1895_Horse", Chinese="Russian 1895（骑兵）", ShortTxt="M1895 Horse" },
        new WeaponName(){ Class="驾驶员下车", English="U_AmmoPouch_Cav", Chinese="弹药包", ShortTxt="Ammo Pouch" },
        new WeaponName(){ Class="驾驶员下车", English="U_Bandages_Cav", Chinese="绷带包", ShortTxt="Bandages" },
        new WeaponName(){ Class="驾驶员下车", English="U_Grenade_AT_Cavalry", Chinese="轻型反坦克手榴弹", ShortTxt="Grenade AT" },
        new WeaponName(){ Class="驾驶员下车", English="U_LugerP08_VhKit", Chinese="P08 手枪", ShortTxt="LugerP08 VhKit" },

        ////////////////
        
        new WeaponName(){ Class="特殊载具", English="ID_P_INAME_U_MORTAR", Chinese="特殊载具 空爆迫击炮", ShortTxt="MORTAR" },
        new WeaponName(){ Class="特殊载具", English="ID_P_INAME_MORTAR_HE", Chinese="特殊载具 高爆迫击炮", ShortTxt="MORTAR HE" },

        /////////////////////////////////////////////////////////////////////////////

        // 运输载具
        new WeaponName(){ Class="运输载具", English="ID_P_VNAME_NSU", Chinese="运输载具 MC 3.5HP 附边车摩托车", ShortTxt="NSU" },
        new WeaponName(){ Class="运输载具", English="ID_P_VNAME_MOTORCYCLE", Chinese="运输载具 MC 18J 附边车摩托车", ShortTxt="MOTORCYCLE" },
        new WeaponName(){ Class="运输载具", English="ID_P_VNAME_EHRHARDT", Chinese="运输载具 EV4 装甲车", ShortTxt="EHRHARDT" },
        new WeaponName(){ Class="运输载具", English="ID_P_VNAME_ROMFELL", Chinese="运输载具 Romfell 装甲车", ShortTxt="ROMFELL" },
        new WeaponName(){ Class="运输载具", English="ID_P_VNAME_ROLLS", Chinese="运输载具 RNAS 装甲车", ShortTxt="ROLLS" },
        new WeaponName(){ Class="运输载具", English="ID_P_VNAME_MODEL30", Chinese="运输载具 M30 侦察车", ShortTxt="MODEL30" },
        new WeaponName(){ Class="运输载具", English="ID_P_VNAME_TERNI", Chinese="运输载具 F.T. 侦察车", ShortTxt="TERNI" },
        new WeaponName(){ Class="运输载具", English="ID_P_VNAME_MERCEDES_37", Chinese="运输载具 37/95 侦察车", ShortTxt="MERCEDES 37" },
        new WeaponName(){ Class="运输载具", English="ID_P_VNAME_BENZ_MG", Chinese="运输载具 KFT 侦察车", ShortTxt="BENZ MG" },
        new WeaponName(){ Class="运输载具", English="ID_P_VNAME_MAS15", Chinese="运输载具 M.A.S 鱼雷快艇", ShortTxt="MAS15" },
        new WeaponName(){ Class="运输载具", English="ID_P_VNAME_YLIGHTER", Chinese="运输载具 Y-Lighter 登陆艇", ShortTxt="MAS15" },

        /////////////////////////////////////////////////////////////////////////////

        // 定点武器
        new WeaponName(){ Class="定点武器", English="ID_P_VNAME_BL9", Chinese="定点武器 BL 9.2 攻城炮", ShortTxt="BL9" },
        new WeaponName(){ Class="定点武器", English="ID_P_VNAME_TURRET", Chinese="定点武器 堡垒火炮", ShortTxt="TURRET" },
        new WeaponName(){ Class="定点武器", English="ID_P_VNAME_AASTATION", Chinese="定点武器 QF 1 防空炮", ShortTxt="AASTATION" },
        new WeaponName(){ Class="定点武器", English="ID_P_VNAME_FIELDGUN", Chinese="定点武器 FK 96 野战炮", ShortTxt="FIELDGUN" },
        new WeaponName(){ Class="定点武器", English="ID_P_INAME_MAXIM", Chinese="定点武器 重机枪", ShortTxt="MAXIM" },
        new WeaponName(){ Class="定点武器", English="ID_P_VNAME_COASTALBATTERY", Chinese="定点武器 350/52 o 岸防炮", ShortTxt="COASTALBATTERY" },
        new WeaponName(){ Class="定点武器", English="ID_P_VNAME_SK45GUN", Chinese="定点武器 SK45 岸防炮", ShortTxt="SK45GUN" },

        /////////////////////////////////////////////////////////////////////////////

        // 战争巨兽
        new WeaponName(){ Class="战争巨兽", English="ID_P_VNAME_ARMOREDTRAIN", Chinese="战争巨兽 装甲列车", ShortTxt="ARMOREDTRAIN" },
        new WeaponName(){ Class="战争巨兽", English="ID_P_VNAME_ZEPPELIN", Chinese="战争巨兽 飞船 l30", ShortTxt="ZEPPELIN" },
        new WeaponName(){ Class="战争巨兽", English="ID_P_VNAME_IRONDUKE", Chinese="战争巨兽 无畏舰", ShortTxt="IRONDUKE" },
        new WeaponName(){ Class="战争巨兽", English="ID_P_VNAME_CHAR", Chinese="战争巨兽 Char 2C", ShortTxt="CHAR" },

        /////////////////////////////////////////////////////////////////////////////
        
        // 近战
        new WeaponName(){ Class="近战武器", English="U_GrenadeClub", Chinese="哑弹棒", ShortTxt="Grenade Club" },
        new WeaponName(){ Class="近战武器", English="U_Club", Chinese="棍棒", ShortTxt="Club" },

        // 其他
        new WeaponName(){ Class="其他", English="U_GasMask", Chinese="防毒面具", ShortTxt="Gas Mask" },
    };
}