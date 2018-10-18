using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 成绩管理系统
{

    class Student
    {
        private string name;
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }
        private string nums;
        public string Nums
        {
            get
            {
                return this.nums;
            }
            set
            {
                this.nums = value;
            }
        }
        private string sex;
        private int grade;
        private string appraise;
        //评价
        public string Appraise
        {
            set
            {
                this.appraise = value;
            }
        }

        private string password;
        public string Password
        {
            get
            {
                return this.password;
            }
            set
            {
                this.password = value;
            }
        }
        private int webscore;
        //web
        private int englishscore;
        //计算机英语
        private int systemscore;
        //计算机系统
        private int mediascore;
        //多媒体
        private int AIscore;
        //人工智能
        private int avg;
        //平均成绩
        private int GPA;
        //平均绩点
        private int rank;
        //排名
        public int Rank
        {
            get
            {
                return this.rank;
            }
            set
            {
                this.rank = value;
            }
        }

        public Student()
        {
            this.change("未命名", "0000", "男", 2016, "未评价", "std", 0, 0, 0, 0, 0, 0, 0, 0);
        }
        //修改学生信息
        public void change(string name, string nums, string sex, int grade, string appraise, string password, int webscore, int englishscore,int systemscore, int mediascore, int AIscore, int avg, int GPA, int rank)
        {
            this.name = name;
            this.nums = nums;
            this.sex = sex;
            this.grade = grade;
            this.appraise = appraise;
            this.password = password;
            this.webscore = webscore;
            this.englishscore = englishscore;
            this.systemscore = systemscore;
            this.mediascore = mediascore;
            this.AIscore = AIscore;
            this.avg = avg;
            this.GPA = GPA;
            this.rank = rank;
        }
        public void setScore(int w, int e, int s, int m, int a)
        {
            this.webscore = w;
            this.englishscore = e;
            this.systemscore = s;
            this.mediascore = m;
            this.AIscore = a;
            this.avg = (w + e + s + m + a) / 5;
            this.GPA = avg >= 60 ? (avg - 50) / 10 : 0;
        }
        public string[] getScore()
        {
            string[] s = { this.webscore.ToString(), this.englishscore.ToString(), this.systemscore.ToString(), this.mediascore.ToString(), this.AIscore.ToString() };
            return s;
        }
        //返回学号
        public string getnums()
        {
            return this.nums;
        }
        //返回avg
        public int getavg()
        {
            return this.avg;
        }
        //返回所有学生信息
        public string all()
        {
            return this.name + " " + this.nums + " " + this.sex + " " + this.grade + " "
                    + this.appraise + " " + this.password + " " + this.webscore + " "
                    + this.englishscore + " " + this.systemscore + " " + this.mediascore + " "
                    + this.AIscore + " " + this.avg + " " + this.GPA + " " + this.rank;
        }
        public string[] allAsArr()
        {

            string[] arr = {this.nums, this.name, this.sex, this.grade.ToString(),
                    this.appraise, this.password, this.webscore.ToString(),
                    this.englishscore.ToString(), this.systemscore.ToString(), this.mediascore.ToString(),
                    this.AIscore.ToString(), this.avg.ToString(), this.GPA.ToString(), this.rank.ToString()};
            return arr;
        }
        public string[] allScoreAsArr()
        {

            string[] arr = {this.nums, this.name,  this.webscore.ToString(),
                    this.englishscore.ToString(), this.systemscore.ToString(), this.mediascore.ToString(),
                    this.AIscore.ToString(), this.avg.ToString(), this.GPA.ToString(), this.rank.ToString()};
            return arr;
        }
    }
    class Students
    {
        private const string STD_FILE = @"stds.txt";
        //学生信息保存文件
        private Dictionary<string, Student> stds;
        //从文件中读取出所有的学生信息存为字典

        public Students()
        {
            this.stds = new Dictionary<string, Student>();
        }
        public bool load()
        {
            using (StreamReader sr = new StreamReader(STD_FILE))
            {
                string []s;
                string ss;
                while((ss = sr.ReadLine()) != null)
                {
                    s = ss.Split(' ');
                    Student std = new Student();
                    std.change(s[0], s[1], s[2], int.Parse(s[3]), s[4], s[5], 
                        int.Parse(s[6]), int.Parse(s[7]), int.Parse(s[8]), int.Parse(s[9]), 
                        int.Parse(s[10]), int.Parse(s[11]), int.Parse(s[12]), int.Parse(s[13]));
                    this.stds.Add(s[1], std);
                }
            }
            return true;
        }

        public bool save()
        {
            using (StreamWriter sw = new StreamWriter(STD_FILE))
            {
                foreach(KeyValuePair<string, Student> std in this.stds)
                {
                    sw.WriteLine(std.Value.all());
                }
            }
            return true;
        }

        public bool add(Student std)
        {
            try
            {
                this.stds.Add(std.getnums(), std);
            }catch(System.ArgumentException e)
            {
                MessageBox.Show("该学号已存在！", "提示");
                return false;
            }
            return true;
        }
        public bool del(string nums)
        {
            if (this.stds.ContainsKey(nums))
            {
                this.stds.Remove(nums);
                return true;
            }
            return false;
        }
        public int size()
        {
            return this.stds.Count;
        }

        public Student get(string nums)
        {
            if (this.stds.ContainsKey(nums))
            {
                return stds[nums];
            }
            return null;
        }
        public string[] avgs()
        {
            string[] s = new string[5];
            int[] sum = { 0, 0, 0, 0, 0 };
            foreach (KeyValuePair<string, Student> std in this.all())
            {
                s = std.Value.getScore();
                sum[0] += int.Parse(s[0]);
                sum[1] += int.Parse(s[1]);
                sum[2] += int.Parse(s[2]);
                sum[3] += int.Parse(s[3]);
                sum[4] += int.Parse(s[4]);
            }
            for (int i = 0; i < sum.Length; i++)
                s[i] = (sum[i] / sum.Length).ToString();
            return s;
        }
        public List<KeyValuePair<string, Student>> all()
        {
            return new List<KeyValuePair<string, Student>>(this.stds);
        }

        public void reset_rank()
        {
            List<KeyValuePair<string, Student>> lst = new List<KeyValuePair<string, Student>>(this.stds);
            lst.Sort(delegate (KeyValuePair<string, Student> s1, KeyValuePair<string, Student> s2)
            {
                return s2.Value.getavg().CompareTo(s1.Value.getavg());
            });
            int i = 1;
            foreach (KeyValuePair<string, Student> std in lst)
            {
                this.stds[std.Value.Nums].Rank = i++;
            }
        }
        public bool change(Student s)
        {
            if (this.stds.ContainsKey(s.Nums))
            {
                stds[s.Nums] = s;
                return true;
            }
            return false;
        }
    }
    class Teacher
    {
        private string name;
        public string Name{
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }
        private string nums;
        public string Nums
        {
            get
            {
                return this.nums;
            }
            set
            {
                this.nums = value;
            }
        }
        private string sex;

        private string password;
        public string Password
        {
            get
            {
                return this.password;
            }
            set
            {
                this.password = value;
            }
        }
        private string leaveword;
        //来自学生的留言
        public string Leaveword
        {
            get
            {
                return this.leaveword;
            }
            set
            {
                this.leaveword = value;
            }
        }

        public Teacher(){
            this.change("未命名", "0000", "男", "admin", "未留言");
        }

        public void change(string name, string nums, string sex, string password, string leaveword)
        {
            this.name = name;
            this.nums = nums;
            this.sex = sex;
            this.password = password;
            this.leaveword = leaveword;
        }
        public string getnums()
        {
            return this.nums;
        }
        public void change_leaveword(string leaveword)
        {
            this.leaveword = leaveword;
        }
        public string all()
        {
            return this.name + " " + this.nums + " " + this.sex + " " 
                + this.password + " " + this.leaveword;
        }
    }

    class Teachers
    {
        private const string TEA_FILE = @"teas.txt";
        //教师信息保存文件
        private Dictionary<string, Teacher> teas;

        public Teachers()
        {
            this.teas = new Dictionary<string, Teacher>();
        }
        public bool add(Teacher tea)
        {
            try
            { 
                this.teas.Add(tea.getnums(), tea);
            }catch (System.ArgumentException)
            {
                MessageBox.Show("该工号已存在！", "提示");
                return false;
            }
            return true;
        }
        public bool load()
        {
            using (StreamReader sr = new StreamReader(TEA_FILE))
            {
                string[] s;
                string ss;
                while ((ss = sr.ReadLine()) != null)
                {
                    s = ss.Split(' ');
                    Teacher tea = new Teacher();
                    tea.change(s[0], s[1], s[2], s[3], s[4]);
                    this.teas.Add(s[1], tea);
                }
            }
            return true;
        }
        public bool save()
        {
            using (StreamWriter sw = new StreamWriter(TEA_FILE))
            {
                foreach (KeyValuePair<string, Teacher> tea in this.teas)
                {
                    sw.WriteLine(tea.Value.all());
                }
            }
            return true;
        }
        public List<KeyValuePair<string, Teacher>> all()
        {
            return new List<KeyValuePair<string, Teacher>>(this.teas);
        }
        public Teacher get(string nums)
        {
            if (this.teas.ContainsKey(nums))
            {
                return teas[nums];
            }
            return null;
        }
        public Teacher getByName(string name)
        {
            foreach (KeyValuePair<string, Teacher> tea in this.teas)
            {
                if (tea.Value.Name == name)
                    return tea.Value;
            }
            return null;
        }
        public bool leave_word(string nums, string leaveword)
        {
            if (this.teas.ContainsKey(nums))
            {
                this.teas[nums].change_leaveword(leaveword);
                return true;
            }
            return false;
        }
        public bool change(Teacher t)
        {
            if (this.teas.ContainsKey(t.Nums))
            {
                teas[t.Nums] = t;
                return true;
            }
            return false;
        }
    }
    class GlobalData
    {
        //全局静态访问使用
        public static Students students;
        public static Teachers teachers;
        public static int who;
        public static Student s;
        public static Teacher t;
        //载入数据
        public static void load()
        {
            students = new Students();
            students.load();
            teachers = new Teachers();
            teachers.load();
            who = 0;
            s = null;
            t = null;
        }
        //登录检查
        public static int check(string id, string password)
        {
            if (id == "admin" && password == "admin")
            {
                who = 1;
            }
            else
            {
                if ((s = students.get(id)) != null && s.Password == password)
                {
                    who = 2;
                }
                else if((t = teachers.get(id)) != null && t.Password == password)
                {
                    who = 3;
                }
            }
            return who;
        }
        public static void save()
        {
            students.save();
            teachers.save();
            MessageBox.Show("保存成功！", "提示");
        }
    }
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            //加载全局变量
            GlobalData.load();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
        private static void test()
        {
            //测试用函数
            Students stds = new Students();
            stds.load();
            foreach (KeyValuePair<string, Student> s in stds.all())
            {
                Console.WriteLine(s.Value.all());
            }
            Student std = new Student();
            std.change("衡与墨", "0001", "男", 2016, "未评价", "std", 0, 0, 0, 0, 0, 0, 0, 0);
            Console.WriteLine(std.all());
            stds.add(std);
            stds.save();
            Teachers teas = new Teachers();
            teas.load();
            foreach (KeyValuePair<string, Teacher> t in teas.all())
            {
                Console.WriteLine(t.Value.all());
            }
            Teacher tea = new Teacher();
            tea.change("陈老师", "0001", "男", "admin", "您真棒！");
            Console.WriteLine(tea.all());
            teas.add(tea);
            teas.save();
        }
    }
}
