using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace VehicleLicenseTax
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        #region 背景執行
        private void Form1_Load(object sender, EventArgs e)
        {
            init(); //初始化
            lblResult.Text = "請輸入日期>輸入載具種類>指定動力種類。" +
                "\r\n以完成試算";
        }
        #endregion
        #region 宣告方法   
        /// <summary>
        /// 查找車種對應之CC數
        /// </summary>
        private Dictionary<int, string> CreateCCList(int key) //車種to引擎l
        {
            /*車種字典*/
            Dictionary<int, string> carSelf = new Dictionary<int, string>(){
                {0,"500cc以下" } ,{1,"501cc-600cc"} ,{2,"601cc-1200cc"},
                {3,"1201cc-1800cc" } ,{4,"1801cc-2400cc"} ,
                {5,"2401cc-3000cc" }  ,{6,"3001cc-4200cc"},
                {7,"4201cc-5400cc" }  ,{8,"5401cc-6600cc"},
                {9,"6601cc-7800cc" }  ,{10,"7801cc以上"}
            };
            Dictionary<int, string> carCom = new Dictionary<int, string>()
            {
                {0,"500cc以下" } ,{1,"501cc-600cc"} ,{2,"601cc-1200cc"},
                {3,"1201cc-1800cc" } ,{4,"1801cc-2400cc"} ,
                {5,"2401cc-3000cc" }  ,{6,"3001cc-4200cc"},
                {7,"4201cc-5400cc" }  ,{8,"5401cc-6600cc"},
                {9,"6601cc-7800cc" }  ,{10,"7801cc以上"}
            };
            Dictionary<int, string> truckCus = new Dictionary<int, string>() {
            {0,"600cc以下" } ,{1,"601cc-1200cc"},
                {2,"1201cc-1800cc" } ,{3,"1801cc-2400cc"} ,
                {4,"2401cc-3000cc" }  ,{5,"3001cc~3600cc"},
                {6,"3601cc~4200cc" }  ,{7,"4201cc~4800cc"},
                {8,"4801cc~5400cc" }  ,{9,"5401cc~6000cc"},
                {10,"6001cc~6600cc" }  ,{11,"6601cc~7200cc"},
                {12,"7201cc~7800cc" }  ,{13,"7801cc~8400cc"},
                {14,"8401cc~9000cc" }  ,{15,"9001cc~9600cc"},
                {16,"9601cc~10200cc" }  ,{17,"10201cc以上"}
            };
            Dictionary<int, string> truckCargo = new Dictionary<int, string>() {
                {0,"500cc以下" } ,{1,"501cc-600cc"} ,{2,"601cc-1200cc"},
                {3,"1201cc-1800cc" } ,{4,"1801cc-2400cc"} ,
                {5,"2401cc-3000cc" }  ,{6,"3001cc~3600cc"},
                {7,"3601cc~4200cc" }  ,{8,"4201cc~4800cc"},
                {9,"4801cc~5400cc" }  ,{10,"5401cc~6000cc"},
                {11,"6001cc~6600cc" }  ,{12,"6601cc~7200cc"},
                {13,"7201cc~7800cc" }  ,{14,"7801cc~8400cc"},
                {15,"8401cc~9000cc" }  ,{16,"9001cc~9600cc"},
                {17,"9601cc~10200cc" }  ,{18,"10201cc以上"}
            };
            Dictionary<int, string> motor = new Dictionary<int, string>() {
            {0,"150cc 以下" } ,{1,"151cc~250cc"} ,{2,"251cc~500cc"},
                {3,"501cc~600cc" } ,{4,"601cc~1200cc"} ,
                {5,"1201cc~1800cc" }  ,{6,"1801cc 以上"}};
            Dictionary<int, string> carSelfEle = new Dictionary<int, string>() {
            {0,"公制馬力(PS)38.6以下/英制馬力(HP)38以下" } ,
            {1,"公制馬力(PS)38.7-56.8/英制馬力(HP)38.1-56" } ,
            {2,"公制馬力(PS)56.9-84.2/英制馬力(HP)56.1-83" } ,
            {3,"公制馬力(PS)84.3-184.7/英制馬力(HP)83.1-182" } ,
            {4,"公制馬力(PS)184.8-265.9/英制馬力(HP)182.1-262" } ,
            {5,"公制馬力(PS)266.0-326.8/英制馬力(HP)262.1-322" } ,
            {6,"公制馬力(PS)326.9-420.2/英制馬力(HP)322.1-414" } ,
            {7,"公制馬力(PS)420.3-476.0/英制馬力(HP)414.1-469" } ,
            {8,"公制馬力(PS)476.1-516.6/英制馬力(HP)469.1-509" } ,
            {9,"公制馬力(PS)516.7以上/英制馬力(HP)509.1以上" }
            };
            Dictionary<int, string> carComEle = new Dictionary<int, string>() {
            {0,"公制馬力(PS)38.6以下/英制馬力(HP)38以下" } ,
            {1,"公制馬力(PS)38.7-56.8/英制馬力(HP)38.1-56" } ,
            {2,"公制馬力(PS)56.9-84.2/英制馬力(HP)56.1-83" } ,
            {3,"公制馬力(PS)84.3-184.7/英制馬力(HP)83.1-182" } ,
            {4,"公制馬力(PS)184.8-265.9/英制馬力(HP)182.1-262" } ,
            {5,"公制馬力(PS)266.0-326.8/英制馬力(HP)262.1-322" } ,
            {6,"公制馬力(PS)326.9-420.2/英制馬力(HP)322.1-414" } ,
            {7,"公制馬力(PS)420.3-476.0/英制馬力(HP)414.1-469" } ,
            {8,"公制馬力(PS)476.1-516.6/英制馬力(HP)469.1-509" } ,
            {9,"公制馬力(PS)516.7以上/英制馬力(HP)509.1以上" } };
            Dictionary<int, string> motorEle = new Dictionary<int, string>() {
            {0,"公制馬力(PS)21.54以下/英制馬力(HP)20.19以下" } ,
            {1,"公制馬力(PS)21.55-42.71/英制馬力(HP)20.20-40.03" } ,
            {2,"公制馬力(PS)42.72-53.43/英制馬力(HP)40.04-50.07" } ,
            {3,"公制馬力(PS)53.44-62.73/英制馬力(HP)50.08-58.79" } ,
            {4,"公制馬力(PS)62.74-121.76/英制馬力(HP)58.80-114.11" } ,
            {5,"公制馬力(PS)121.77以上/英制馬力(HP)114.12以上" } ,};
            Dictionary<int, string> truckEle = new Dictionary<int, string>() {
                { 0,"公制馬力(PS)140.1以下/英制馬力(HP)138以下"},
                { 1,"公制馬力(PS)140.2-203/英制馬力(HP)138.1-200"},
                { 2,"公制馬力(PS)203.1-250.7/英制馬力(HP)200.1-247"},
                { 3,"公制馬力(PS)250.8-290.3/英制馬力(HP)247.1-286"},
                { 4,"公制馬力(PS)290.4-341/英制馬力(HP)286.1-336"},
                { 5,"公制馬力(PS)341.1-366.4/英制馬力(HP)336.1-361"},
                { 6,"公制馬力(PS)366.5以上/英制馬力(HP)361.1以上"},            };
            Dictionary<int, string> tractor = new Dictionary<int, string>() {
            {0,"500cc以下" } ,{1,"501cc-600cc"} ,{2,"601cc-1200cc"},
                {3,"1201cc-1800cc" } ,{4,"1801cc-2400cc"} ,
                {5,"2401cc-3000cc" }  ,{6,"3001cc~3600cc"},
                {7,"3601cc~4200cc" }  ,{8,"4201cc~4800cc"},
                {9,"4801cc~5400cc" }  ,{10,"5401cc~6000cc"},
                {11,"6001cc~6600cc" }  ,{12,"6601cc~7200cc"},
                {13,"7201cc~7800cc" }  ,{14,"7801cc~8400cc"},
                {15,"8401cc~9000cc" }  ,{16,"9001cc~9600cc"},
                {17,"9601cc~10200cc" }  ,{18,"10201cc以上"}};

            /*檢索給第二comboBox的清單*/
            Dictionary<int, Dictionary<int, string>> dicOfDic = new Dictionary<int, Dictionary<int, string>>() {
             {3, carSelf},{5, carSelf}, {4, carCom},
             {2, truckCus},  {1, truckCargo},
             {0, motor},  {7, carSelfEle},
             {8, carComEle},  {9, motorEle},
             {10, truckEle},{6, tractor} };


            Dictionary<int, string> answer = new Dictionary<int, string>();
            answer = dicOfDic[key];
            return answer;
        }
        /// <summary>
        /// 查找CC數對應之稅額
        /// </summary>        
        private int FindTax(string key, string key2) //引擎to稅金
        {

            /*cc數-稅率字典群*/
            Dictionary<string, int> carSelf = new Dictionary<string, int>()
            { {"500cc以下" ,1620} ,{"501cc-600cc",2160} ,{"601cc-1200cc",4320},
                {"1201cc-1800cc",7120 } ,{"1801cc-2400cc",11230} ,
                {"2401cc-3000cc" ,15210}  ,{"3001cc-4200cc",28220},
                {"4201cc-5400cc" ,46170}  ,{"5401cc-6600cc",69690},
                {"6601cc-7800cc" ,117000}  ,{"7801cc以上",151200}
            };
            Dictionary<string, int> carCom = new Dictionary<string, int>() {
            {"500cc以下" ,900} ,{"501cc-600cc",1260} ,{"601cc-1200cc",2160},
                {"1201cc-1800cc",3060 } ,{"1801cc-2400cc",6480} ,
                {"2401cc-3000cc" ,9900}  ,{"3001cc-4200cc",16380},
                {"4201cc-5400cc" ,24300}  ,{"5401cc-6600cc",33660},
                {"6601cc-7800cc" ,44460}  ,{"7801cc以上",56700}};
            Dictionary<string, int> truckCus = new Dictionary<string, int>() {
                {"600cc以下",1080 } ,{"601cc-1200cc",1800},
                {"1201cc-1800cc" ,2700} ,{"1801cc-2400cc",3600} ,
                {"2401cc-3000cc", 4500}  ,{"3001cc~3600cc",5400},
                {"3601cc~4200cc" ,6300}  ,{"4201cc~4800cc",7200},
                {"4801cc~5400cc", 8100}  ,{"5401cc~6000cc",9000},
                {"6001cc~6600cc" ,9900}  ,{"6601cc~7200cc",10800},
                {"7201cc~7800cc",11700 }  ,{"7801cc~8400cc",12600},
                {"8401cc~9000cc", 13500}  ,{"9001cc~9600cc",14400},
                {"9601cc~10200cc", 15300}  ,{"10201cc以上",16200}};
            Dictionary<string, int> truckCargo = new Dictionary<string, int>()
            {  {"500cc以下" ,900} ,{"501cc-600cc",1080} ,{"601cc-1200cc",1800},
                {"1201cc-1800cc", 2700} ,{"1801cc-2400cc",3600} ,
                {"2401cc-3000cc" ,4500}  ,{"3001cc~3600cc",5400},
                {"3601cc~4200cc", 6300}  ,{"4201cc~4800cc",7200},
                {"4801cc~5400cc", 8100}  ,{"5401cc~6000cc",9000},
                {"6001cc~6600cc", 9900}  ,{"6601cc~7200cc",10800},
                {"7201cc~7800cc" ,11700}  ,{"7801cc~8400cc",12600},
                {"8401cc~9000cc", 13500}  ,{"9001cc~9600cc",14400},
                {"9601cc~10200cc", 15300}  ,{"10201cc以上",16200}};
            Dictionary<string, int> motor = new Dictionary<string, int>() {
            {"150cc 以下",0 },{"151cc~250cc",800 },{"251cc~500cc",1620 },
            {"501cc~600cc",2160 },{"601cc~1200cc",4320 },
            {"1201cc~1800cc",7120 },{"1801cc 以上",11230 }
            };
            Dictionary<string, int> carSelfEle = new Dictionary<string, int>() {
            {"公制馬力(PS)38.6以下/英制馬力(HP)38以下" ,1620} ,
            {"公制馬力(PS)38.7-56.8/英制馬力(HP)38.1-56", 2160} ,
            {"公制馬力(PS)56.9-84.2/英制馬力(HP)56.1-83" ,4320} ,
            {"公制馬力(PS)84.3-184.7/英制馬力(HP)83.1-182",7120 } ,
            {"公制馬力(PS)184.8-265.9/英制馬力(HP)182.1-262",11230 } ,
            {"公制馬力(PS)266.0-326.8/英制馬力(HP)262.1-322" ,15210} ,
            {"公制馬力(PS)326.9-420.2/英制馬力(HP)322.1-414" ,28220} ,
            {"公制馬力(PS)420.3-476.0/英制馬力(HP)414.1-469" ,46170} ,
            {"公制馬力(PS)476.1-516.6/英制馬力(HP)469.1-509" ,69690} ,
            {"公制馬力(PS)516.7以上/英制馬力(HP)509.1以上" ,117000}};
            Dictionary<string, int> carComEle = new Dictionary<string, int>()
            { {"公制馬力(PS)38.6以下/英制馬力(HP)38以下" ,900} ,
            {"公制馬力(PS)38.7-56.8/英制馬力(HP)38.1-56" ,1260} ,
            {"公制馬力(PS)56.9-84.2/英制馬力(HP)56.1-83" ,2160} ,
            {"公制馬力(PS)84.3-184.7/英制馬力(HP)83.1-182", 3060} ,
            {"公制馬力(PS)184.8-265.9/英制馬力(HP)182.1-262",6480 } ,
            {"公制馬力(PS)266.0-326.8/英制馬力(HP)262.1-322" ,9900} ,
            {"公制馬力(PS)326.9-420.2/英制馬力(HP)322.1-414" ,16380} ,
            {"公制馬力(PS)420.3-476.0/英制馬力(HP)414.1-469" ,24300} ,
            {"公制馬力(PS)476.1-516.6/英制馬力(HP)469.1-509" ,33660} ,
            {"公制馬力(PS)516.7以上/英制馬力(HP)509.1以上" ,44460} };
            Dictionary<string, int> motorEle = new Dictionary<string, int>() {
            {"公制馬力(PS)21.54以下/英制馬力(HP)20.19以下", 0} ,
            {"公制馬力(PS)21.55-42.71/英制馬力(HP)20.20-40.03",800 } ,
            {"公制馬力(PS)42.72-53.43/英制馬力(HP)40.04-50.07", 1620} ,
            {"公制馬力(PS)53.44-62.73/英制馬力(HP)50.08-58.79",2160 } ,
            {"公制馬力(PS)62.74-121.76/英制馬力(HP)58.80-114.11" ,4320} ,
            {"公制馬力(PS)121.77以上/英制馬力(HP)114.12以上", 7120} ,};
            Dictionary<string, int> truckEle = new Dictionary<string, int>() {
                {"公制馬力(PS)140.1以下/英制馬力(HP)138以下",4500},
                {"公制馬力(PS)140.2-203/英制馬力(HP)138.1-200",6300},
                {"公制馬力(PS)203.1-250.7/英制馬力(HP)200.1-247",8100},
                {"公制馬力(PS)250.8-290.3/英制馬力(HP)247.1-286",9900},
                {"公制馬力(PS)290.4-341/英制馬力(HP)286.1-336",11700},
                {"公制馬力(PS)341.1-366.4/英制馬力(HP)336.1-361",13500},
                {"公制馬力(PS)366.5以上/英制馬力(HP)361.1以上",15300}, };
            Dictionary<string, int> tractor = new Dictionary<string, int>() {
                {"500cc以下" ,1170} ,{"501cc-600cc",1404} ,{"601cc-1200cc",2340},
                {"1201cc-1800cc", 3510} ,{"1801cc-2400cc",4680} ,
                {"2401cc-3000cc" ,5850}  ,{"3001cc~3600cc",7020},
                {"3601cc~4200cc", 8190}  ,{"4201cc~4800cc",9360},
                {"4801cc~5400cc", 10530}  ,{"5401cc~6000cc",11700},
                {"6001cc~6600cc", 12870}  ,{"6601cc~7200cc",14040},
                {"7201cc~7800cc" ,15210}  ,{"7801cc~8400cc",16380},
                {"8401cc~9000cc", 17550}  ,{"9001cc~9600cc",18720},
                {"9601cc~10200cc", 19890}  ,{"10201cc以上",21060} };

            /*檢索對應車種之cc數表單*/
            Dictionary<string, Dictionary<string, int>> dicOfDic = new Dictionary<string, Dictionary<string, int>>()
            {{"自用小客車",carSelf}, {"小客貨兩用車",carSelf}, {"營業用小客車",carCom},
             {"大客車",truckCus},  {"貨車",truckCargo},
             {"機車",motor},  {"自用電動小客車",carSelfEle},
             {"營業用電動小客車",carComEle},  {"電動機車",motorEle},
             {"電動大客車",truckEle},{"曳引車",tractor} };

            var Viechle = dicOfDic[key];
            var answer = Viechle[key2];
            return answer;
        }

        /// <summary>
        /// 初始化
        /// </summary>
        //全部初始化
        private void init()
        {
            radioButtonYear.Checked = false;
            radioButtonCustom.Checked = false;
            comboBoxCars.Items.Clear();
            comboBoxCC.Items.Clear();
            comboBoxCC.Text = "";
            lblResult.Text = "";
            _taxbase = -1;
            TimeStart_ctrl(false);
            TimeEnd_ctrl(false);


        }
        //時間初始化
        private void initTime()
        {
            if (_eachYear != null) { _eachYear.Clear(); }
            if (_eachDuration != null) { _eachDuration.Clear(); }
            if (_eachYearMemo_Start != null) { _eachYearMemo_Start.Clear(); }
            if (_eachYearMemo_end != null) { _eachYearMemo_end.Clear(); }
        }
        ///時間選項初始化
        private void TimeStart_ctrl(bool Ctrl)
        {

            _checkIfSelectedTime_A = calDateStart.Enabled = calDateStart.Visible = Ctrl;
        }
        private void TimeEnd_ctrl(bool Ctrl)
        {

            _checkIfSelectedTime_B = calDateEnd.Enabled = calDateEnd.Visible = Ctrl;
        }



        /// <summary>
        /// 取得日曆日期差
        /// </summary>
        private int GetDuration(DateTime Start, DateTime End)
        {

            var answer = new TimeSpan(End.Ticks - Start.Ticks).Days + 1;
            return answer;
        }
        /// <summary>
        /// 取得是否為閏年
        /// </summary>
        //for頭尾年
        private bool FindIfZoomYear(int Year)
        {
            if (DateTime.IsLeapYear(Year))
            {
                _eachYear.Add(366);
                return true;
            }
            else
            {
                _eachYear.Add(365);
                return false;
            }

        }
        //for魚中身年/整年份
        private bool FindIfZoomYearFish(int Year)
        {
            _eachYearMemo_Start.Add(new DateTime(Year, 1, 1));
            _eachYearMemo_end.Add(new DateTime(Year, 12, 31));
            if (DateTime.IsLeapYear(Year))
            {
                _eachYear.Add(366);
                _eachDuration.Add(366);
                return true;
            }
            else
            {
                _eachYear.Add(365);
                _eachDuration.Add(365);
                return false;
            }
        }
        #endregion
        #region 宣告變數區
        private int _taxbase = -1;
        private List<int> _eachDuration = new List<int>();
        private List<int> _eachYear = new List<int>();
        private List<DateTime> _eachYearMemo_Start = new List<DateTime>();
        private List<DateTime> _eachYearMemo_end = new List<DateTime>();
        private bool _checkIfSelectedTime_A = false;
        private bool _checkIfSelectedTime_B = false;
        private List<string> _listForViechle = new List<string>()
        {"機車","貨車","大客車","自用小客車","營業用小客車","小客貨兩用車","曳引車","自用電動小客車","營業用電動小客車","電動機車","電動大客車"};

        #endregion
        #region 使用期間
        //全年度
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            TimeStart_ctrl(false);
            TimeEnd_ctrl(false);
            this.calDateStart.Value = new DateTime(DateTime.Now.Year, 1, 1);//起始日
            this.calDateEnd.Value = new DateTime(DateTime.Now.Year, 12, 31);//終了日
            initTime();
            FindIfZoomYearFish(calDateStart.Value.Year);
            this._checkIfSelectedTime_A = this._checkIfSelectedTime_B = true;
        }
        //自訂時間
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            TimeStart_ctrl(true);
            TimeEnd_ctrl(true);
            this.calDateStart.Value = new DateTime(DateTime.Now.Year, 1, 1);//起始日
            this.calDateEnd.Value = new DateTime(DateTime.Now.Year, 12, 31);//終了日      
            initTime();
            //_eachDuration.Add(1);
            FindIfZoomYearFish(calDateStart.Value.Year);
            this._checkIfSelectedTime_A = this._checkIfSelectedTime_B = false;
        }

        //起始日期處理
        private void calDateStart_ValueChanged(object sender, EventArgs e)
        {
            initTime();
            var fishHead_YEnd = new DateTime(calDateStart.Value.Year, 12, 31);
            var fishTail_YStart = new DateTime(calDateEnd.Value.Year, 1, 1);
            var fishHead = GetDuration(calDateStart.Value, fishHead_YEnd);
            var fishTail = GetDuration(fishTail_YStart, calDateEnd.Value);
            var fish = GetDuration(calDateStart.Value, calDateEnd.Value);

            if (calDateEnd.Value.Year - calDateStart.Value.Year >= 2)
            {
                FindIfZoomYear(calDateStart.Value.Year); //處理魚頭
                this._eachDuration.Add(fishHead);
                this._eachYearMemo_Start.Add(new DateTime(calDateStart.Value.Year,
                    calDateStart.Value.Month, calDateStart.Value.Day));
                this._eachYearMemo_end.Add(new DateTime(calDateStart.Value.Year,
                    12, 31));

                for (int i = calDateStart.Value.Year + 1; i < calDateEnd.Value.Year; i++)
                { //處理魚身
                    FindIfZoomYearFish(i);
                }
                FindIfZoomYear(calDateEnd.Value.Year); //處理魚尾
                this._eachDuration.Add(fishTail);
                this._eachYearMemo_Start.Add(new DateTime(calDateEnd.Value.Year,
                   1, 1));
                this._eachYearMemo_end.Add(new DateTime(calDateEnd.Value.Year,
                   calDateEnd.Value.Month, calDateEnd.Value.Day));
            }
            else if (calDateEnd.Value.Year - calDateStart.Value.Year == 1)
            {
                FindIfZoomYear(calDateStart.Value.Year); //處理魚頭
                this._eachDuration.Add(fishHead);
                this._eachYearMemo_Start.Add(new DateTime(calDateStart.Value.Year,
                    calDateStart.Value.Month, calDateStart.Value.Day));
                this._eachYearMemo_end.Add(new DateTime(calDateStart.Value.Year,
                  12, 31));

                FindIfZoomYear(calDateEnd.Value.Year); //處理魚尾
                this._eachDuration.Add(fishTail);
                this._eachYearMemo_Start.Add(new DateTime(calDateEnd.Value.Year,
                   1, 1));
                this._eachYearMemo_end.Add(new DateTime(calDateEnd.Value.Year,
                   calDateEnd.Value.Month, calDateEnd.Value.Day));
            }
            else if (calDateEnd.Value.Year <= calDateStart.Value.Year)
            {
                FindIfZoomYear(calDateStart.Value.Year);
                this._eachDuration.Add(fish);
                this._eachYearMemo_Start.Add(new DateTime(calDateStart.Value.Year,
                    calDateStart.Value.Month, calDateStart.Value.Day));
                this._eachYearMemo_end.Add(new DateTime(calDateEnd.Value.Year,
                    calDateEnd.Value.Month, calDateEnd.Value.Day));
            }
        }
        //終了日期處理
        private void calDateEnd_ValueChanged(object sender, EventArgs e)
        {
            initTime();
            var fishHead_YEnd = new DateTime(calDateStart.Value.Year, 12, 31);
            var fishTail_YStart = new DateTime(calDateEnd.Value.Year, 1, 1);
            var fishHead = GetDuration(calDateStart.Value, fishHead_YEnd);
            var fishTail = GetDuration(fishTail_YStart, calDateEnd.Value);
            var fish = GetDuration(calDateStart.Value, calDateEnd.Value);

            if (calDateEnd.Value.Year - calDateStart.Value.Year >= 2)
            {
                FindIfZoomYear(calDateStart.Value.Year); //處理魚頭
                this._eachDuration.Add(fishHead);
                this._eachYearMemo_Start.Add(new DateTime(calDateStart.Value.Year,
                    calDateStart.Value.Month, calDateStart.Value.Day));
                this._eachYearMemo_end.Add(new DateTime(calDateStart.Value.Year,
                    12, 31));

                for (int i = calDateStart.Value.Year + 1; i < calDateEnd.Value.Year; i++)
                { //處理魚身
                    FindIfZoomYearFish(i);
                }
                FindIfZoomYear(calDateEnd.Value.Year); //處理魚尾
                this._eachDuration.Add(fishTail);
                this._eachYearMemo_Start.Add(new DateTime(calDateEnd.Value.Year,
                   1, 1));
                this._eachYearMemo_end.Add(new DateTime(calDateEnd.Value.Year,
                   calDateEnd.Value.Month, calDateEnd.Value.Day));
            }
            else if (calDateEnd.Value.Year - calDateStart.Value.Year == 1)
            {
                FindIfZoomYear(calDateStart.Value.Year); //處理魚頭
                this._eachDuration.Add(fishHead);
                this._eachYearMemo_Start.Add(new DateTime(calDateStart.Value.Year,
                    calDateStart.Value.Month, calDateStart.Value.Day));
                this._eachYearMemo_end.Add(new DateTime(calDateStart.Value.Year,
                  12, 31));

                FindIfZoomYear(calDateEnd.Value.Year); //處理魚尾
                this._eachDuration.Add(fishTail);
                this._eachYearMemo_Start.Add(new DateTime(calDateEnd.Value.Year,
                   1, 1));
                this._eachYearMemo_end.Add(new DateTime(calDateEnd.Value.Year,
                   calDateEnd.Value.Month, calDateEnd.Value.Day));
            }
            else if (calDateEnd.Value.Year <= calDateStart.Value.Year)
            {
                FindIfZoomYear(calDateStart.Value.Year);
                this._eachDuration.Add(fish);
                this._eachYearMemo_Start.Add(new DateTime(calDateStart.Value.Year,
                    calDateStart.Value.Month, calDateStart.Value.Day));
                this._eachYearMemo_end.Add(new DateTime(calDateEnd.Value.Year,
                    calDateEnd.Value.Month, calDateEnd.Value.Day));
            }
        }

        #endregion
        #region 車種

        private void comboBoxCars_MouseDown(object sender, MouseEventArgs e)
        {
            this.comboBoxCars.Items.Clear();
            foreach (string element in _listForViechle)
            {
                this.comboBoxCars.Items.Add(element);
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.comboBoxCC.Items.Clear();
            var creater = CreateCCList(comboBoxCars.SelectedIndex);
            for (int i = 0; i < creater.Count; i++)
            {
                this.comboBoxCC.Items.Add(creater[i]);
            }
        }


        #endregion
        #region 汽缸CC數／馬達馬力
        private void comboBoxCC_SelectedIndexChanged(object sender, EventArgs e)
        {
            //var a =Convert.ToString(comboBoxCC.SelectedItem);
            var key = this.comboBoxCars.Text;
            var key2 = this.comboBoxCC.Text;
            this._taxbase = FindTax(key, key2);
            //var taxbase = FindTax(key, key2);
            //lblResult.Text = Convert.ToString(taxbase);            
        }
        #endregion
        #region 送出/清除
        //送出前控制項
        private void calDateStart_MouseDown(object sender, MouseEventArgs e)
        {
            this._checkIfSelectedTime_A = true;
        }

        private void calDateEnd_MouseDown(object sender, MouseEventArgs e)
        {
            this._checkIfSelectedTime_B = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //送出前檢查
            if (this._checkIfSelectedTime_A == false || this._checkIfSelectedTime_B == false)
            {
                if (this._checkIfSelectedTime_A == false && this._checkIfSelectedTime_B == false)
                {
                    this.lblResult.Text = "請指定[開始] / [結束]時間";
                }
                else if (_checkIfSelectedTime_B == false)
                {
                    this.lblResult.Text = "請指定[結束]時間";
                }
                else
                {
                    this.lblResult.Text = "請指定[開始]時間";
                }
            }
            else if (this._eachDuration[0] <= 0 || this._eachDuration == null)
            {
                this.lblResult.Text = "時間為負，請指定正確時間";
            }
            else if (this.comboBoxCars.SelectedIndex == -1 || this.comboBoxCC.SelectedIndex == -1)
            {
                this.lblResult.Text = "不能找到指定車種，請完善條件";
            }
            else
            {
                //計算
                this.lblResult.Text = "";
                decimal finalAnswer = 0;
                decimal eachAnswer;

                for (int i = 0; i < _eachYear.Count; i++)
                {
                    eachAnswer = (this._taxbase * this._eachDuration[i] / this._eachYear[i]);
                    finalAnswer += eachAnswer;
                    this.lblResult.Text += $"使用期間：{this._eachYearMemo_Start[i].ToString("yyyy/MM/dd")}" +
                    $"~{this._eachYearMemo_end[i].ToString("yyyy/MM/dd")}。\r\n" +
                    $"計算天數：{this._eachDuration[i]}日。\r\n" +
                    $"載具種類：{this.comboBoxCars.Text}。\r\n" +
                    $"引擎種類：{this.comboBoxCC.Text}。\r\n" +
                    $"計算公式：{this._taxbase}*{this._eachDuration[i]}/{this._eachYear[i]}={eachAnswer}。\r\n" +
                    $"----------\r\n";


                }
                this.lblResult.Text += $"總使用期間：{this.calDateStart.Value.ToString("yyyy/MM/dd")}" +
                 $"~{this.calDateEnd.Value.ToString("yyyy/MM/dd")}。\r\n" +
                 $"應納稅額: 共 {finalAnswer} 元。\r\n" +
                 $"==============";

            }

        }
        private void button2_Click(object sender, EventArgs e)
        {
            init();
        }
        #endregion
    }
}