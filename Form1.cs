﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private string[] d = { "000000", "000001", "000010", "000011", "000100", "000101", "000110", "000111", "001000", "001001", "001010", "001011",
            "001100", "001101", "001110", "001111", "010000", "010001", "010010", "010011", "010100", "010101", "010110", "010111", "011000", "011001",
            "011010", "011011", "011100", "011101", "011110", "011111", "100000", "100001", "100010", "100011", "100100", "100101", "100110", "100111",
            "101000", "101001", "101010", "101011", "101100", "101101", "101110", "101111", "110000", "110001", "110010", "110011", "110100", "110101",
            "110110", "110111", "111000", "111001", "111010", "111011", "111100", "111101", "111110", "111111",  };


        private string[] f = { "地为坤", "地雷复", "地水师", "地泽临", "地山谦", "地火明夷", "地风升", "地天泰", "雷地豫", "震为雷", "雷水解", "雷泽归妹",
            "雷山小过", "雷火丰", "雷风恒", "雷天大壮", "水地比", "水雷屯", "坎为水", "水泽节", "水山蹇", "水火既济", "水风井", "水天需", "泽地萃", "泽雷随",
            "泽水困", "兑为泽", "泽山咸", "泽火革", "泽风大过", "泽天央", "山地剥", "山雷颐", "山水蒙", "山泽损", "艮为山", "山火贲", "山风蛊", "山天大畜",
            "火地晋", "火雷噬嗑", "火水未济", "火泽睽", "火山旅", "离为火", "火风鼎", "火天大有", "风地观", "风雷益", "风水涣", "风泽中孚", "风山渐",
            "风火家人", "翼为风", "风天小畜", "天地否", "天雷无妄", "天水讼", "天泽履", "天山遁", "天火同人", "天风始", "乾为天", };


        private string[] liu = { "大安","流连","速喜","赤口","小吉","空亡"};


        private string[] xxs = { "谋事最难成，坐家不安宁，病人遇恶鬼，空亡下凶灵。","弱苗遭冰霜，病兔逢箭伤，瞎子又闹眼，瘸夫足生疮。　","事难又久长，心闷迷茫茫，出事不如意，无吉没日光。　",
            "现在无坎坷，只因群积德，为人必须善，慈仁好事多。　","枯树逢和春，万象吉祥新，求财处处有，办事也顺心。　","行善喜事多，处处有吉色，云消见晴天，吉祥唱欢歌。　",
            "杯落茶壶上，两者都俱伤，吉利事情少，劝群细推详。　","一根独木桥，二人对行吵，互相不退让，各自不谦饶。　","事事成功晚，罗嗦又麻烦，口舌处处有，九曲三声怨。　",
            "家中 病夫好，喜气吉祥娇，当地办事吉，守家方为妙。　","迷雾刚消散，重见艳阳天，眼望春色美，顺开万里船。　","骂声已消尽，此刻又称心，冬苗逢暖雨，百草到阳春。　",
            "枯苗逢冰雪，残冰遇烈阳，事事不称心，不欢不吉详。　","有病在途中，忍苦耐艰痛，口舌继续有，事事不由功。　","推车半路上，轮坏不转向，进退都为难，途中而彷徨。　",
            "家中忙碌多，事事平常过，吉利家中有，庭院唱喜歌。　","冰化逢新春，雪融处处新，福禄迎面来，吉利又顺心。　","久盼在心间，今日重回还，喜气满屋乐，福光盈庭欢。　",
            "病夫家 中养，多不复回康，财钱都消散，何时得安详。　","此项犯口舌，家中闹事多，是非不在远，就在本庄过。　","事事成全晚，九曲又三弯，郁闷时时有，小事成而变。　",
            "劝君守门庭，不用远方行，贵人自来助，喜气满堂迎。　","万事如意长，吉利照高堂，荣华称心贵，金银有满仓。　","事事都如意，家外迎来喜，此刻福禄多，满堂春大吉，　",
            "破事犯口骂，白露浸幼芽，虽是无大伤，妨寒苗再发。　","碌碌不停闲，阴云扔阴暗，无风驱云走，无力拨雾散。　","独坐喜气堂，坐享友人帮，此刻安居吉，补好前创伤。　",
            "得志回家 中，面色颜光红，枯苗得甘雨，如药辞别冬。　","云散见青天，雨停看远山，风平浪又静，顺利万里船。　","寒风刮冷鸟，烈火烧野草，不吉不顺利，好事变为糟。　",
            "有风也有雪，口舌不见缺，诸事难遂心，成功变坏裂。　","败祸有余伤，暂时有痛痒，望君稍停动，乱事得安详。　","希君莫远行，等待事自兴，虽然前事愁，今庭得安宁。　",
            "贵人得相助，出行遇福禄，小人刚安宁，喜气满心处。　","更换门庭喜，又逢各事吉，驱散远天云，称心又如意。　","狂浪卷小舟，苦海无尽头，劝群积德善，为人要忠厚。　",
            "空亡伴赤口 ，哭泣与忧愁，无人来解助，漂泊独自游。　","冷雨不停阴，连绵拖沉沉，行走泥泞难，进退两忧闷。　","久伤刚合口，居养能无忧，痊处有疤痕，以防炎回头。　",
            "破网补合好，小喜微量少，打鱼撒几网，看去乱糟糟。　","荒地草锄净，望去一片春，草根继续发，希君要惕警。　","乞丐遭狂犬，喧闹投进险，行处事变空，哭啼受艰难。　",
            "三项逢赤口，骂声如水流，希君单项赏，细节而知透。　","口舌不消散，小人不安闲，谅解方为贵，寡言才为安。　","闹吵骂声有，劝群在家守，谦让无是非，安居严闭口。　",
            "口舌刚消闲， 乐喜到身边，此刻得小顺，提妨小人嫌。　","讽刺击声停，雷雨寒刚晴，闭口少言语，笑见喜气迎。　","豆腐掉灰炕，吹打尘不净，怨持长久骂，忍耐苦哀声。　",
            "赤口连赤口，事多全忧愁，诽谤嘲讥骂，连连无消头。　","囚鸟半空悬，呼伴喊多年，无人开笼门，怎能回林间。　","腿患无法行，进退都不能，求事成功晚，只可守门庭。　",
            "吵嘴出家园，顺心回乡转，如意多年求，吉祥照身边。　"," 急气远离家，得意逢荣华，虽然志成迟，喜光照容霞。　","深秋逢寒雨，冷风透草居，屋破漏水急，凉夜怎能宿。　",
            "劝君莫远走，在家也闭口，万事都作怪，千怨家患忧。　","久病愈后患，只待治牵连，疑猜刚守口，守家事缠绵。　","遥村无云烟，劝君庭中安，喜乐事会有，不在远天边。",
            "远方雾消尽，福气满堂春，希君安床坐，运转自上门。","喜气进高堂，广财迎吉祥，天边口舌散，事事如意昌。","幼苗遭风霜，重种晚春阳，讽言讥语过，成事化败伤。",
            "好事犯口舌，劝有君少说，本是不为已，情意变仇恶。　","谋事受奔波 ，处处犯罗嗦，事事不及时，迷雾心思多。","此项福气兴，只因守门庭，有人来相助，坐等自然成。　",
            "求财十分量，须有贵人帮，福乐欢在心，如意都顺当。","遂顺皆如意，前病愈逢喜，吉祥增称心，乐欢加详吉。　","事成不遂心，处处有小人，本是春和日，推来寒阴云。",
            "口舌又重返，好意落漫怨，不言无事闹，忠言即劝君。　","喜事成功晚，望君记心间，近日事升兴，过去口舌连。","安居得 安宁，喜光照门庭，礼义明迎友，贵人提高升。　",
            "衣禄自然来，天才有安排，如意称心乐，远边淡雾开。","金榜留美名，得意享太平，吉祥事事好，六合处处通。　","福气自来修，运气无根由，多年劳禄成，一事空皆休。",
            "劳心事事空，口舌满西东，常忧叹气多，笑语多愁容。　","空亡担留连，百事难成全，遥望远方去，运气在何边。","深冬刚已过，庭中见奇色，因为身没动，才能喜中得。　",
            " 多年连没成，运气即将兴，驱散满天云，迎来万里睛。","金针苦中磨，年月岁日多，今日刚欲成，心中有喜乐。　","少费计较舌，说话更罗嗦，诸事成功少，处处小人多。",
            "久坐监牢中，打骂苦中疼，为人必行善，作恶事事凶。　","赤口挑留连，前后有牵连，怨声中求好，还需过几天。","骂嘴在耳边，家中听不见，安乐自无忧，有人登门劝。　",
            "风雨刚停晴，心中喜乐兴，求事多费力，求吉有喜迎。","秋月逢阳春，枯苗见绿新，口舌刚消尽，微喜乐在心。　","盲人又闹目，旧衣又破处，鱼网破烂孔，乱团又难捕。",
            "鸭落冷井中， 打水桶叮咚，寒饥愁游浮，何日出头容。　","三项逢留连，详看单项筒，求是日未明，凡事只宜缓。","事事都未成，家中有光明，远望雾茫茫，近看心宽荣。　",
            "笼鸟得逃生，寻伴找同性，串山又越岭，重回原林中。","阴雨得晴天，时来有运转，欲盼有几秋，好运在今现。　","多年病在床，医治不复康，今又遇邪鬼，恐怕见阎王。",
            "此刻别出门，出门遇哑人，病人多作怪，怒气冲在身。　","远行足 受伤，回头转归乡，行走痛苦忍，到达深夜堂。","病夫今起床，窗前望春光，院内绿色新，室内盆花香。　",
            "贵人自动来，得喜遇小财，只因身未动，欢乐见异彩。","总无行远门，安堂良逢辰，远友来相助，坐床迎贵人。　","多日积柴草，此时遭火烧，财来如夜露，一晨晒净消。",
            "多年往一屋，两家总争诉，分开不能分，吵闹在一处。　","乘船游在江，撒下几次网，这次网挂住，下水冰寒凉。","多 想得财源，守家盼金山，因无差旅费，安居在甲院。　",
            "久病刚复康，得需营养补，天天海味美，日日山珍香。","远出海捕鱼，满船回岸去，人人在庆贺，多年才成玉。　","漏船行江心，发现浸下沉，虽告利良日，惊惕预防君。",
            "病夫愈猜说，好后犯罗嗦，呻吟声声紧，前程有坎坷。　","时阴又时晴，时雾云零星，雁秋南方去，明春北回程。","花儿数日栽，今堂刚见开，守看色更美，移出寒风来。　",
            "外出行买卖，数日没回来，今有吉利时，欢乐发小财。","远乡作生意，兴隆挂锦衣，虽然出多年，还是称心地。　","雨中一病鸟， 飞爬遇冰雹，艰苦无相助，何日得晴消。",
            "项中迷漫漫，骂声传无边，情意成怨去，口舌连篇篇。　","外出有小灾，怨骂犯重来，长期不消散，本村受吵害。","枯树又复活，当地现春色，遭风冷冻霜，未动艰难过。　",
            "冬麦又复春，坐地刚湿润，堂中逢吉醒，破屋得新门。","圆月升青天，今宵照家园，家家沾德泽，上空净云烟。　","守业扔受究，钱箱有蛀虫，庄田禾苗好，又遭霜雪冻。",
            "破房又漏 屋，凉炕躺病夫，呻吟哀声叫，骂吵变为哭。　","坐家心不宁，急声接吵声，多日事不顺，总也不消停。","口舌续在手，在家方为秀，在屋商量事，闹急才能休。　",
            "房内有泼妇，骂消又蛮鲁，只因逢速喜，脸上有笑吐。","家中急声无，舌尖见喜富，君在寻找财，欢乐在此处。　","寒窗三冬冷，盆花一枯容，昨夜狂风雪，又遭一窗冰。",
            "家人久怨气，无和温言意，处处犯小语，吵闹长时期。　","室 间当奴人，骂声变吵音，家里苦忙碌，怨气受不尽。","母鸡一个蛋，几天没出现，只可耐心等，动手有危险。　",
            "家中思发财，坐等自然来，等了多少日，此刻喜颜开。","坐屋久盼好，此刻将吉姣，阴云天缝日，一会不见了。　","闲坐倒杯茶，凉杯遇热炸，烫伤自己手，惹得他人骂。",
            "家床在梦中，惊骂吵吓醒，是非远遑有，闭口无事情。　","院内放见筝，柳树挂线绳，不能上树解，又难硬拉挣。","三项逢大安，何必思出远，安居得顺利，守屋为安闲。　",
            "家中忙不休，财产自到手，室内全是宝，劝莫远方游。","窗前一盆花，室 内出新芽，安居又逢春，温中在萌发。　","洗衣在晒凉，没干遇风狂，刮到泥土里，造成一服脏。",
            "家中遇小财，惹得他人猜，好事口舌中，可能非道来。　","行路推破车，泥泞有陡坡，要它真费力，扔了扔不得。","霖雨滋苗秀，何愁不广收，安身心得乐，家中居无忧。　",
            "当地求谋生，不必远方行，虽然发小财，日日都兴隆。","此项占六和，求财喜气多，远人归家乡，逢喜全家乐。　","单人远意 求，不慎陷深沟，因没听劝语，有祸自造成。",
            "好心变歹意，谎舌要提记，成事化计吵，如鸭争闹鸡。　","弯月升上天，看物仔细想，朦胧夜间影，知清等明天。","久居安吉乐，出行无欢歌，日吉时安居，窗前观远色。　",
            "财富在本乡，称心而荣光，事事都如意，在家得吉祥。","当地得高名，福气此地生，安居财禄贵，万事如意兴。　","迢遥途中间，云横日坠山，羁心无可托，前后总皆难。",
            "尘埋 青铜镜，美玉隐泥泞，何日得出生，口舌怨声净。　","伤心离家走，得吉再回头，掉进陷井里，逃身几日久。","蚌自珠中详，石内玉争光，进财家求望，有祸不成殃。　",
            "三姓俱相伴，祥光得共生，更宜分造化，小事自然成。","高名居禄庆，笼鸟得逃生。出入多财宝，更宜远方行。　","枯木逢霜冻，小舟遇大风，惊心无可望，百事不亨通。",
            "口舌处处有，希君莫出走，日时犯最重，良言也为仇。　","计划好周全，做起成功晚，怨声长不消，成事有化变。","生家观景美，出门遇脏水，欢乐不周合，劝君急堂归。　",
            "喜事口舌来，因 冷花不开，今逢气侯转，速拜见鲜彩。","急急用意求，拨零见清秀，口舌稍减少，时及自无忧。　","鸟寻食充饥，鸡进牢笼里，何日得出险，久期不吉利。",
            "履薄登冰地，危桥得度急，重重忧险过，迟成怨口啼。　","求望有多天，往返又变迁，虽得微喜月，变化而牵连。","心事盼已久，推云见日头，吉堂安稳坐，切莫半寸走。　",
            "碌碌若中求，奔走怎得休，今逢一刻喜，急去喜心头。","夙望遥遥乡 ，久盼远远方，逢此一顺间，速作得吉祥。　","征马登程处，饥人走远途，前程多阻扼，退后福方无。",
            "外出是非多，口舌在此刻，事事不遂心，言语有克破。　","心事盼多天，九曲又十弯，何时得吉利，需必等几旦。","此日又逢时，在家无非是，切莫远处行，安居又逢此。　",
            "喜气庄中存，欢乐在屯村，小吉为小顺，小事刚见真。","大吉家中有，安居福中求，此日堂间喜，切莫远方走。　","此项 不吉祥，灾危不可挡，凡事最不利，目下有灾殃。",
            "小吉逢诽骂，遇见无吉话，此刻是非多，幼苗见霜花。　","微喜迟中生，贵人提荐成，生意将见宜，好事迟缓行。","动作因风尘，求谋可托人，若在家安居，事事得称心。　",
            "根实枝叶茂，林多格式高，经营多得利，兰蕙似蓬蒿。","日出临东瀛，光辉天下明，动用和合吉，百事自然成。　","破舟在江河，岸略获宝多，眼望航过取，舱内有灾祸。",
            " 喜事逢口舌，成中有曲折，贵人在劝解，怨言水中火。　","且吉君子安，勿用小人言，凡事皆当谨，好事牵连晚。","好德承天佑，门招喜气秀，有人相助力，获福安居守。　",
            "昔情得安宁，钱财渐渐兴，进财求望吉，有福亦安平。","往事今吉祥，意业如心想，作福保安然，吉利也顺当。　","心思多不定，求谋未得成，忍耐方为福，闭口免灾星。",
            "此中多恍惚，交往暗里磨，思深成怨去，笑语变骂舌。　","服药将身安，缠绵词讼连，百凡宜守旧，作福时拖延。","从恶皆消灭，端福然气生，如人行暗夜，时安得天明。　",
            "进取逢通归 ，寒儒衣锦回，何人古此项，凡事任施为。","灾散福门开，无边喜气来，目下相逢处，须当得横财。　","口舌又逢凶，灾祸更加重，数日众疑猜，事事全变空。",
            "一个漏桶悬，挂在门上边，凡是由此过，那有无骂言。　","避怨劝君转，怨气已久患，办事换别时，以防受牵连。","时逢融和晴，衰残物再兴，更得微细雨，春色又还生。　",
            "此项冬树架，苦落未开花，看看春色动，渐渐发萌芽。","喜从怨 中来，乐花骂中开，本是富里生，又被恶语埋。　","月吉不算吉，日却延长期，此刻逢空亡，本项不吉利。",
            "劝君要少言，小人在身边，忠语变恶意，好事又成晚。　","故想变幻妄，身披破鱼网，又在密林行，劝君要提防。","多盼得喜来，安居自得彩，凡事迟后成，从堂等花开。　",
            "早望时逢喜，拖线挂草地，摘掉心中乐，刻在微乐吉。","久去又回村，喜盼才得今，今天此刻好，逢福赋予君。　"," 井底观明月，见影却无形，凡事成功少，谨守得安宁。",
            "口舌犯量重，在家冷如科，办事少话语，好事化恶凶。　","出行迟缓归，守家心烦存，口舌继续在，迷迷变返遥。","守株呆待兔，出行财少无，安居可得乐，劝君别出屋。　",
            "目下喜来临，小事相求亲，交往暂时成，成功在本村。","凡事做神仙，何时来运转，若不逢此日，金鱼上青天。　","欢乐变悲伤，灾危不可当，本是成吉事，此刻成空亡。",
            "船行在江内，口猜恐漏水，喜气不为吉，好事变成非。　","凡事多变迁，成功化长缓，月日因逢喜，动作因风变。","微喜在家堂， 交易乐短长，求借小事可，大事不全当。　",
            "此项算一般，有喜在心间，小事能得顺，大业有缺陷。","月祥日缺一，时辰而逢吉，万事能称心，处处都如意。　","好事变为凶，此刻没成功，有成也有败，逢中更为重。",
            "知音化诽谎，口舌防无伤，有解也有助，闭口无事张。　","月日逢小吉，迟拖望君记，凡事只宜缓，成全变晚期。","欢乐又平安，福气把君劝，虽是月日吉，时莫动身贤。　",
            "喜气自 然生，是非全消尽，如果待一刻，而为吉上等。","万事都吉祥，如意又荣光，平安加富贵，福喜逢华阳。"};


        private string[] dys = { "111","112","113","114","115","116","121","122","123","124","125","126","131","132","133","134","135","136","141","142","143",
            "144","145","146","152","153","154","155","156","161","162","163","164","165","166","211","212","213","214","215","216","221","222","223","224","225",
            "226","231","232","233","234","235","236","241","242","243","244","245","246","251","252","253","254","255","256","261","262","263","264","265","266",
            "311","312","313","314","315","316","321","322","323","324","325","326","331","332","333","334","335","336","341","342","343","344","345","346","351",
            "352","353","354","355","356","361","362","363","364","365","366","411","412","413","414","415","416","421","422","423","424","425","426","431","432",
            "433","434","435","436","441","442","443","444","445","446","451","452","453","454","455","456","461","462","463","464","465","466","511","512","513",
            "514","515","516","521","522","523","524","525","526","531","532","533","534","535","536","541","542","543","544","545","546","551","552","553","554",
            "555","556","561","562","563","564","565","566","611","612","613","614","615","616","621","622","623","624","625","626","631","632","633","634","635",
            "636","641","642","643","644","645","646","651","652","653","654","655","656","661","662","663","664","665","666" };

        private string[] px = {"111","011","101", "001", "110", "010" ,"100","000"};

        private int y = 0;
        private int r = 0;
        private int s = 0;
        private int n = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            Random rd = new Random();
            string[] b = new string[6];
            string c = "";
            for (int i = 0; i < 6; i++)
            {
                string a =  rd.Next(0,2).ToString();
                if (a == "1")
                {
                    b[i] = "---";
                    System.Threading.Thread.Sleep(10);
                }
                if (a == "0")
                {
                    b[i] = "- -";
                    System.Threading.Thread.Sleep(10);
                }

                c += a;
            }
            l1.Text = b[0];
            l2.Text = b[1];
            l3.Text = b[2];
            l4.Text = b[3];
            l5.Text = b[4];
            l6.Text = b[5];

            int ia = 0;
            int ib = 0;
            for (ia = 0; ia < 64; ia++)
            {
                if (c == d[ia])
                {
                    ib = ia;
                    break;
                }
            }
            label1.Text = f[ib];




        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var calendar = new ChineseLunisolarCalendar();
            var dateTime = DateTime.Now;

            var nianGanzhi = calendar.GetSexagenaryYear(dateTime);
            var niangan = calendar.GetCelestialStem(nianGanzhi);
            var nianzhi = calendar.GetTerrestrialBranch(nianGanzhi);

            var yue = calendar.GetMonth(dateTime);
            var runyue = calendar.GetLeapMonth(calendar.GetYear(dateTime));
            bool isRunyue;
            if (runyue is 0 || yue < runyue)
                isRunyue = false;
            else
            {
                isRunyue = yue == runyue;
                yue--;
            }

            var ri = calendar.GetDayOfMonth(dateTime);

            var hour = calendar.GetHour(dateTime);
            if (hour % 2 == 1)
                hour++;
            var shi = hour / 2 + 1;
            y = yue;   
            r = ri;
            s = shi;

            label4.Text = "当前时辰  ：" + y + "月" + r + "日" + s + "时";


        }

        private void l6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var calendar = new ChineseLunisolarCalendar();
            var dateTime = DateTime.Now;

            var nianGanzhi = calendar.GetSexagenaryYear(dateTime);
            var niangan = calendar.GetCelestialStem(nianGanzhi);
            var nianzhi = calendar.GetTerrestrialBranch(nianGanzhi);

            var yue = calendar.GetMonth(dateTime);
            var runyue = calendar.GetLeapMonth(calendar.GetYear(dateTime));
            bool isRunyue;
            if (runyue is 0 || yue < runyue)
                isRunyue = false;
            else
            {
                isRunyue = yue == runyue;
                yue--;
            }

            var ri = calendar.GetDayOfMonth(dateTime);

            var hour = calendar.GetHour(dateTime);
            if (hour % 2 == 1)
                hour++;
            var shi = hour / 2 + 1;

            y = yue;
            r = ri;
            s = shi;


            label4.Text = "当前时辰  ：" + y + "月" + r + "日" + s+"时";



            int zs = y + r + s - 2;
            int zzs = zs % 6;
            if (zzs <= 0)
            {
                zzs = 6;
            }

            label2.Text = liu[zzs-1];



            int xx1 = y % 6;
            if (xx1 <= 0)
            {
                xx1 = 6;
            }
            int xx2 = (r + y - 1) % 6;
            if (xx2 <= 0)
            {
                xx2 = 6;
            }
            int xx3 = (s + r + y - 2) % 6;
            if (xx3 <= 0)
            {
                xx3 = 6;
            }
            string xx = xx1.ToString() + xx2.ToString() + xx3.ToString();
            int iia = 0;
            int iib = 0;
            for (iia = 0; iia < 215; iia++)
            {
                if (xx == dys[iia])
                {
                    iib = iia;
                    break;
                }
            }
            label3.Text = xxs[iib];
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ///
            ///获取农历时间
            ///
            var calendar = new ChineseLunisolarCalendar();
            var dateTime = DateTime.Now;

            var nianGanzhi = calendar.GetSexagenaryYear(dateTime);
            var niangan = calendar.GetCelestialStem(nianGanzhi);
            var nianzhi = calendar.GetTerrestrialBranch(nianGanzhi);
            var nian = calendar.GetYear(dateTime);

            var yue = calendar.GetMonth(dateTime);
            var runyue = calendar.GetLeapMonth(calendar.GetYear(dateTime));
            bool isRunyue;
            if (runyue is 0 || yue < runyue)
                isRunyue = false;
            else
            {
                isRunyue = yue == runyue;
                yue--;
            }

            var ri = calendar.GetDayOfMonth(dateTime);

            var hour = calendar.GetHour(dateTime);
            if (hour % 2 == 1)
                hour++;
            var shi = hour / 2 + 1;
            y = yue;
            r = ri;
            s = shi;
            n = nianGanzhi;

            ///
            ///获取体卦
            ///
            int ss1 = (n + y + r) % 8;
            if (ss1 <= 0)
            { ss1 = 8; }
            int ss2 = (n + y + r + s )% 8;
            if (ss2 <= 0)
            { ss2 = 8; }

            string ss = px[ss1-1] + px[ss2-1];
            int ii = 0;
            string[] sss = new string[6];
            for (ii = 0; ii < 6; ii++) 
            {
                if (ss.Substring(ii,1) == "1")
                {
                    sss[ii] = "---";
                }
                if (ss.Substring(ii, 1) == "0")
                {
                    sss[ii] = "- -";
                }
            }
            t1.Text = sss[0];
            t2.Text = sss[1];
            t3.Text = sss[2];
            t4.Text = sss[3];
            t5.Text = sss[4];
            t6.Text = sss[5];

            int ia = 0;
            int ib = 0;
            for (ia = 0; ia < 64; ia++)
            {
                if (ss == d[ia])
                {
                    ib = ia;
                    break;
                }
            }
            label5.Text = f[ib];

            ///
            ///获取变卦
            ///
            int ss4 = (n + y + r + s) % 6;
            if (ss4 <= 0)
            { ss4 = 6; }

            string[] ssb = new string[6];
            for (int aa = 0;aa<6;aa++)
            {
                ssb[aa]=ss.Substring(aa,1);
            }

            if (ssb[7-ss4-1] == "1")
            {
                ssb[7-ss4 - 1] = "0";
                goto aa;
            }
            if (ssb[7-ss4 - 1] == "0")
            {
                ssb[7 - ss4 - 1] = "1";
            }

        aa:
            string cs = ssb[0] + ssb[1] + ssb[2] + ssb[3] + ssb[4] + ssb[5];
            string[] ssb1 = new string[6];
            int iii = 0;
            for (iii = 0; iii < 6; iii++)
            {
                if (ssb[iii] == "1")
                {
                    ssb1[iii] = "---";
                }
                if (ssb[iii] == "0")
                {
                    ssb1[iii] = "- -";
                }
            }
            b1.Text = ssb1[0];
            b2.Text = ssb1[1];
            b3.Text = ssb1[2];
            b4.Text = ssb1[3];
            b5.Text = ssb1[4];
            b6.Text = ssb1[5];

            int ia2 = 0;
            int ib2 = 0;
            for (ia2 = 0; ia2 < 64; ia2++)
            {
                if (cs == d[ia2])
                {
                    ib2 = ia2;
                    break;
                }
            }
            label7.Text = f[ib2];

            ///
            ///互卦
            ///
            h1.Text = sss[1];
            h2.Text = sss[2];
            h3.Text = sss[3];
            h4.Text = sss[2];
            h5.Text = sss[3];
            h6.Text = sss[4];


            string[] csss = new string[6];
            csss[0] = sss[1];
            csss[1] = sss[2];
            csss[2] = sss[3];
            csss[3] = sss[2];
            csss[4] = sss[3];
            csss[5] = sss[4];


            string css = "";
            for (int i1 = 0; i1 < 6; i1++)
            {
                if (csss[i1] == "---")
                {
                    css += "1";
                }
                if (csss[i1] == "- -")
                {
                    css += "0";
                }
            }


            int css1 = 0;
            int css2 = 0;
            for (css1 = 0; css1 < 64; css1++)
            {
                if (css == d[css1])
                {
                    css2 = css1;
                    break;
                }
            }
            label6.Text = f[css2];

        }

        private void button4_Click(object sender, EventArgs e)
        {
            ///
            ///获取数据
            ///

            if (textBox1.Text == "")
            {
                MessageBox.Show("请输入内容");
                return;
            }

            var calendar = new ChineseLunisolarCalendar();
            var dateTime = DateTime.Now;
            var hour = calendar.GetHour(dateTime);
            if (hour % 2 == 1)
                hour++;
            var shi = hour / 2 + 1;

            s = shi;
            int a = int.Parse(textBox1.Text);

            ///
            ///体卦
            ///
            int ss1 = a % 8;
            if (ss1 <= 0)
            { ss1 = 8; }
            int ss2 = (a + s) % 8;
            if (ss2 <= 0)
            { ss2 = 8; }

            string ss = px[ss1 - 1] + px[ss2 - 1];
            int ii = 0;
            string[] sss = new string[6];
            for (ii = 0; ii < 6; ii++)
            {
                if (ss.Substring(ii, 1) == "1")
                {
                    sss[ii] = "---";
                }
                if (ss.Substring(ii, 1) == "0")
                {
                    sss[ii] = "- -";
                }
            }
            t1.Text = sss[0];
            t2.Text = sss[1];
            t3.Text = sss[2];
            t4.Text = sss[3];
            t5.Text = sss[4];
            t6.Text = sss[5];

            int ia = 0;
            int ib = 0;
            for (ia = 0; ia < 64; ia++)
            {
                if (ss == d[ia])
                {
                    ib = ia;
                    break;
                }
            }
            label5.Text = f[ib];

            ///
            ///变卦
            ///
            int ss4 = (a + s) % 6;
            if (ss4 <= 0)
            { ss4 = 6; }

            string[] ssb = new string[6];
            for (int aa = 0; aa < 6; aa++)
            {
                ssb[aa] = ss.Substring(aa, 1);
            }

            if (ssb[7 - ss4 - 1] == "1")
            {
                ssb[7 - ss4 - 1] = "0";
                goto aa;
            }
            if (ssb[7 - ss4 - 1] == "0")
            {
                ssb[7 - ss4 - 1] = "1";
            }

        aa:
            string cs = ssb[0] + ssb[1] + ssb[2] + ssb[3] + ssb[4] + ssb[5];
            string[] ssb1 = new string[6];
            int iii = 0;
            for (iii = 0; iii < 6; iii++)
            {
                if (ssb[iii] == "1")
                {
                    ssb1[iii] = "---";
                }
                if (ssb[iii] == "0")
                {
                    ssb1[iii] = "- -";
                }
            }
            b1.Text = ssb1[0];
            b2.Text = ssb1[1];
            b3.Text = ssb1[2];
            b4.Text = ssb1[3];
            b5.Text = ssb1[4];
            b6.Text = ssb1[5];

            int ia2 = 0;
            int ib2 = 0;
            for (ia2 = 0; ia2 < 64; ia2++)
            {
                if (cs == d[ia2])
                {
                    ib2 = ia2;
                    break;
                }
            }
            label7.Text = f[ib2];

            ///
            ///互卦
            ///
            h1.Text = sss[1];
            h2.Text = sss[2];
            h3.Text = sss[3];
            h4.Text = sss[2];
            h5.Text = sss[3];
            h6.Text = sss[4];


            string[] csss = new string[6];
            csss[0] = sss[1];
            csss[1] = sss[2];
            csss[2] = sss[3];
            csss[3] = sss[2];
            csss[4] = sss[3];
            csss[5] = sss[4];


            string css = "";
            for (int i1 = 0; i1 < 6; i1++)
            {
                if (csss[i1] == "---")
                {
                    css += "1";
                }
                if (csss[i1] == "- -")
                {
                    css += "0";
                }
            }


            int css1 = 0;
            int css2 = 0;
            for (css1 = 0; css1 < 64; css1++)
            {
                if (css == d[css1])
                {
                    css2 = css1;
                    break;
                }
            }
            label6.Text = f[css2];

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

                if (e.KeyChar < '0' || e.KeyChar > '9') // 判断按下的键是否为数字
                {
                    e.Handled = true;
                }
            
        }
    }
}