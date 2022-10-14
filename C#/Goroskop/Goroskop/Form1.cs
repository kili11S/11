using System;
using System.Windows.Forms;
namespace Goroskop
{
    public partial class Form1 : Form
    {
        static int a = 0;

        public Form1()
        {
            InitializeComponent();
            LBcurrent.Text += DateTime.Today.ToShortDateString();
            DateTime DateTimeToday = DateTime.Today;
            int DateTimeYear = DateTimeToday.Year;
            if (DateTime.IsLeapYear(DateTimeYear) == true)
                lb_LeapYear.Text += "да";
            else
                lb_LeapYear.Text += "нет";
        }

        private void BTresult_Click(object sender, EventArgs e)
        {
            // Очистка поля 
            TBresult.Clear();

            // ДР
            DateTime btDATE = DTbirthpick.Value;
            TBresult.Text += btDATE.ToShortDateString() + Environment.NewLine;

            // Настоящая дата
            DateTime crDATE = DateTime.Today; // Дата

            // Сколько прожито
            int DAYS = crDATE.Day - btDATE.Day;
            int MONTHS = btDATE.Month - crDATE.Month;
            int YEARS = crDATE.Year - btDATE.Year;
            TimeSpan interbal1 = crDATE - btDATE;

            if (btDATE.Month > crDATE.Month)
            {
                MONTHS -= 12;
            }

            if (btDATE.Month == crDATE.Month)
            {
                MONTHS = 0;
            }

            if (btDATE.Year > crDATE.Year)
            {
                YEARS ++;
            }

            if (btDATE.Year < crDATE.Year)
            {
                YEARS --;
            }

            TBresult.Text += "Вы прожили полных " + YEARS + " лет, " + "полных " + Math.Abs(MONTHS) + " месяцев и " + Math.Abs(DAYS) + " дней." + "\r\n";
            TBresult.Text += "Вы прожили уже " + interbal1.Days + " дней." + Environment.NewLine;

            // ДР: Високосный год
            if (DateTime.IsLeapYear(btDATE.Year))
            {
                TBresult.Text += "Вы родились в високосный год ^_^ " + Environment.NewLine;
            }
                
            else
            {
                TBresult.Text += "Вы родились в невисокосный год @_@" + Environment.NewLine;
            }

            // ДР: День недели
            TBresult.Text += "Вы родились в " + (Convert.ToString(btDATE.DayOfWeek)) + Environment.NewLine;

            // Прошло/осталось
            DateTime Prozhito = new DateTime(crDATE.Year, btDATE.Month, btDATE.Day);
            int xz = DateTime.Compare(crDATE, Prozhito);
            TimeSpan interval = (Prozhito - crDATE);

            // ДР будет
            if (xz < 0) 
            {
                TBresult.Text += "До вашего дня рождения осталось: " + interval.Days + " дней" + Environment.NewLine;
            }

            // ДР прошло
            if (xz > 0) 
            {
                TBresult.Text += "Со дня рождения прошло " + interval.Days * -1 + " дней" + Environment.NewLine; // -1 возвращает число в положительное
            }

            // ДР
            if (xz == 0)
            {
                TBresult.Text += "У вас сегодня день рождения! От всей души желаем счастья, здоровья и чтобы беды вас не настигали" + Environment.NewLine;
            }

            TBresult.Text += Environment.NewLine; 

            // Знаки зодиака
            int btDAY = btDATE.Day, btMONTH = btDATE.Month;

            // Овен
            if ((btDAY >= 21 && btMONTH == 3) || (btDAY <= 20 && btMONTH == 4))
            {
                pbZZ.Image = Properties.Resources.Oven;
                pbZODIAC.Image = Properties.Resources.Овен;
                TBresult.Text += "Знак зодиака: Овен" + Environment.NewLine + "Нескончаемая энергия и неутомимость Овнов стали легендарными равно как и их упорство, а также полное отсутствие уступчивости и компромисса. " +
                    "Овны не уступают ни при каких обстоятельствах, что может пагубно сказаться для них, особенно в молодом возрасте, когда еще нет достаточного жизненного опыта, для уравновешивания своей пылкости" + Environment.NewLine;
            }

            // Телец
            if ((btDAY >= 21 && btMONTH == 4) || (btDAY <= 21 && btMONTH == 5))
            {
                pbZZ.Image = Properties.Resources.Telec;
                pbZODIAC.Image = Properties.Resources.Телец;
                TBresult.Text += "Знак зодиака: Телец" + Environment.NewLine + "Тельцы необычайно добры по отношению к окружающим, но иногда их доброта выглядит нелепо. " +
                    "Представители этого знака, иногда слишком настойчиво навязывают окружающим свое мнение, а так же призывают брать с себя пример, не пренебрегают и другими способами манипулирования людьми. " +
                    "Ложь Тельцы просто не переносят, но иногда все же сами лгут, и их слова внушают людям доверие." + Environment.NewLine;
            }

            // Близнецы
            if ((btDAY >= 22 && btMONTH == 5) || (btDAY <= 21 && btMONTH == 6))
            {
                pbZZ.Image = Properties.Resources.Bliznecy;
                pbZODIAC.Image = Properties.Resources.Близнецы;
                TBresult.Text += "Знак зодиака: Близнецы" + Environment.NewLine + "Близнецы чрезвычайно наблюдательны, но не умеют извлекать из этого плюсы; они часто становятся подозрительны и недоверчивы, обращая внимание на не стоящие того мелочи и совсем неверно трактуя их. " +
                    "Близнецы часто завидуют, и уверенно в том, что живут в окружении таких же завистников как и они. Близнецы - загадочный знак, и понять их довольно трудно. " +
                    "Многие полагают, что они лицемеры и лгуны, но стоит понять, что если Близнецы обманывают, то прежде всего себя." + Environment.NewLine;
                }
            // Рак

                if ((btDAY >= 22 && btMONTH == 6) || (btDAY <= 22 && btMONTH == 7))
                {
                    pbZZ.Image = Properties.Resources.Rak;
                    pbZODIAC.Image = Properties.Resources.Рак;
                TBresult.Text += "Знак зодиака: Рак" + Environment.NewLine + "Рак обладает благородством и бескорыстием, но проявлять эти качества он не спешит, поэтому со стороны он покажется влюбленным в себя эгоистом. " +
                    "У Раков завышенная самооценка, поэтому, оказавшись в центре внимания, они начинают вести себя вызывающе. Рак любит лесть и внимание, но воспринимает их как должное. " +
                    "Так же, представители этого знака, придают большое значение материальным ценностям." + Environment.NewLine;
                }

                // Лев
                if ((btDAY >= 23 && btMONTH == 7) || (btDAY <= 23 && btMONTH == 8))
                {
                    pbZZ.Image = Properties.Resources.Lev;
                    pbZODIAC.Image = Properties.Resources.Лев;
                TBresult.Text += "Знак зодиака: Лев" + Environment.NewLine + "Львы имеют много приятелей, но далеко не ко всем из них они испытывают тепло. " +
                "Дело в том что они слишком часто окружают себя выгодными для себя людьми, не обращая внимания на их достоинства. " +
                "Иногда Львы сами себя критикуют за такое поведение, но по-прежнему ведут себя так же. Учиться на ошибках они не предпочитают, и все блага считают собственной заслугой, а неудачи относят к преградам судьбы." + Environment.NewLine;
                }

                // Дева
                if ((btDAY >= 24 && btMONTH == 8) || (btDAY <= 23 && btMONTH == 9))
                {
                    pbZZ.Image = Properties.Resources.Deva;
                    pbZODIAC.Image = Properties.Resources.Дева;
                TBresult.Text += "Знак зодиака: Дева" + Environment.NewLine + "Представители этого знака привлекательны внешне и могли бы быть неотразимы, если бы захотели. " +
                    "Но им комфортнее находиться в тени, не привлекать к себе внимания, поэтому их часто недооценивают, особенно те, кто их мало знает." + Environment.NewLine;
                }

                // Весы
                if ((btDAY >= 24 && btMONTH == 9) || (btDAY <= 23 && btMONTH == 10))
                {
                    pbZZ.Image = Properties.Resources.Vesi;
                    pbZODIAC.Image = Properties.Resources.Весы;
                TBresult.Text += "Знак зодиака: Весы" + Environment.NewLine + "Весы, которые знают о непостоянстве своего характера, стараются практично подходить к жизни и принимать только верные решения, однако часто, сами того не подозревая, попадают под влияние других людей, и совершают немыслимые для себя поступки. " +
                "Чего Весам не хватает - так это умения доверять самому себе. " +
                "Если они научатся это делать, то избегут много проблем." + Environment.NewLine;
                }

                // Скорпион
                if ((btDAY >= 24 && btMONTH == 10) || (btDAY <= 21 && btMONTH == 11))
                {
                    pbZZ.Image = Properties.Resources.Scropion;
                    pbZODIAC.Image = Properties.Resources.Скорпион;
                TBresult.Text += "Знак зодиака: Скорпион" + Environment.NewLine + "Скорпионы не спрашивают мнение других, а свое высказывают даже тогда, когда их и не спрашивают, игнорируя при этом рамки приличия. " +
                    "Они способные опровергнуть даже общеизвестный факт, и переубедить их будет попросту невозможно. " +
                    "Железная уверенность в собственной правоте не позволяет им идти на компромисс.." + Environment.NewLine;

                }

                // Стрелец
                if ((btDAY >= 23 && btMONTH == 11) || (btDAY <= 21 && btMONTH == 12))
                {
                    pbZZ.Image = Properties.Resources.Strelec;
                    pbZODIAC.Image = Properties.Resources.Стрелец;
                    TBresult.Text += "Знак зодиака: Стрелец" + Environment.NewLine + "Это отважные и решительные люди. Они не терпят ограничений в свободе. " +
                        "Стремятся проявлять свою индивидуальность, выходить за установленные обществом рамки. " +
                        "Они уникальны, у них свой взгляд на мир и особые устремления." + Environment.NewLine;
                }

                // Козерог
                if ((btDAY >= 22 && btMONTH == 12) || (btDAY <= 20 && btMONTH == 1))
                {
                    pbZZ.Image = Properties.Resources.Козерог1;
                    pbZODIAC.Image = Properties.Resources.Козерог;
                TBresult.Text += "Знак зодиака: Козерог" + Environment.NewLine + "Со стороны, кажется что Козерог спокоен и уравновешен, но внутри у него прячется стремление к лидерству и власти, которое он попросту не в состоянии контролировать. " +
                "Именно из них получаются самые жестокие тираны, если их не останавливают традиции и нравы, верность которым Козероги обычно сохраняют." + Environment.NewLine;
                }

                // Водолей
                if ((btDAY >= 21 && btMONTH == 1) || (btDAY <= 18 && btMONTH == 2))
                {
                    pbZZ.Image = Properties.Resources.Vodoley;
                    pbZODIAC.Image = Properties.Resources.Водолей;
                TBresult.Text += "Знак зодиака: Водолей" + Environment.NewLine + "Водолея выделяет любопытство и желание интересоваться любыми сферами жизни. " +
                "Это, правда, мешает им сосредоточиться на чем-то одном, и обычно Водолей показаться ленивым, хотя за день способен выполнить много мелких дел. " +
                "Способность обучаться новому многих из Водолеев делает просто гениями, но, это чревато психическими расстройствами, и поэтому многие из таких людей являются душевно больными." + Environment.NewLine;
                }

                // Рыбы
                if ((btDAY >= 19 && btMONTH == 2) || (btDAY <= 20 && btMONTH == 3))
                {

                    pbZZ.Image = Properties.Resources.Riby;
                    pbZODIAC.Image = Properties.Resources.Рыбы;
                TBresult.Text += "Знак зодиака: Рыбы" + Environment.NewLine + "Постоянством Рыбы похвастаться не могут: они склонны отказываться от своих обещаний или и вовсе забывать о них, менять свои взгляды, и, ценя дружбу в целом, жертвовать интересами близких людей. " +
                "Так же, они могут позволить себе ложь, чтобы приукрасить себя в глазах окружающих, а то и просто без всякой причины." + Environment.NewLine;
                }

                TBresult.Text += Environment.NewLine;

                // Года
                if ((btDATE.Year) % 12 == 0)
                {
                    pbEASTZODIAC.Image = Properties.Resources.Обезьяна;
                    TBresult.Text += "Вы родились в год обезьяны" + Environment.NewLine + "Это люди, обладающие умом, ловкостью, оригинальностью, изобретательностью и изворотливостью. " +
                        "Они очень легко решают самые сложные проблемы при помощи лукавства, ума и хитрости. " +
                        "Обезьяна изобретательна и оригинальна, способна решать самые трудные проблемы с удивительной быстротой.";
                }

                if (btDATE.Year % 12 == 1)
                {
                    pbEASTZODIAC.Image = Properties.Resources.Петух;
                    TBresult.Text += "Вы родились в год петух" + Environment.NewLine + "Это самые настоящие прагматики, трудолюбивые и ответственные. " +
                        "Эти качества помогают им добиться того образа жизни, к которому они стремятся. Среди большой компании Крыс легко узнать, благодаря своей яркости и прекрасному чувству юмора, поэтому их так любят окружающие.";
                }

                if ((btDATE.Year) % 12 == 2)
                {
                    pbEASTZODIAC.Image = Properties.Resources.Собака;
                    TBresult.Text += "Вы родились в год собаки" + Environment.NewLine + "Это самые настоящие прагматики, трудолюбивые и ответственные. " +
                        "Эти качества помогают им добиться того образа жизни, к которому они стремятся. Среди большой компании Крыс легко узнать, благодаря своей яркости и прекрасному чувству юмора, поэтому их так любят окружающие.";
                }

                if ((btDATE.Year) % 12 == 3)
                {
                    pbEASTZODIAC.Image = Properties.Resources.Свинья;
                    TBresult.Text += "Вы родились в год кабана" + Environment.NewLine + "Это самые настоящие прагматики, трудолюбивые и ответственные. " +
                        "Эти качества помогают им добиться того образа жизни, к которому они стремятся. Среди большой компании Крыс легко узнать, благодаря своей яркости и прекрасному чувству юмора, поэтому их так любят окружающие.";
                }

                if ((btDATE.Year) % 12 == 4)
                {
                    pbEASTZODIAC.Image = Properties.Resources.rat;
                    TBresult.Text += "Вы родились в год мышь" + Environment.NewLine + "Это самые настоящие прагматики, трудолюбивые и ответственные. " +
                        "Эти качества помогают им добиться того образа жизни, к которому они стремятся. Среди большой компании Крыс легко узнать, благодаря своей яркости и прекрасному чувству юмора, поэтому их так любят окружающие.";
                }

                if ((btDATE.Year) % 12 == 5)
                {
                    pbEASTZODIAC.Image = Properties.Resources.Бык;
                    TBresult.Text += "Вы родились в год буйвола" + Environment.NewLine + "Это самые настоящие прагматики, трудолюбивые и ответственные. " +
                        "Эти качества помогают им добиться того образа жизни, к которому они стремятся. Среди большой компании Крыс легко узнать, благодаря своей яркости и прекрасному чувству юмора, поэтому их так любят окружающие.";
                }

                if ((btDATE.Year) % 12 == 6)
                {
                    pbEASTZODIAC.Image = Properties.Resources.Тигр;
                    TBresult.Text += "Вы родились в год тигра" + Environment.NewLine + "Это самые настоящие прагматики, трудолюбивые и ответственные. " +
                        "Эти качества помогают им добиться того образа жизни, к которому они стремятся. Среди большой компании Крыс легко узнать, благодаря своей яркости и прекрасному чувству юмора, поэтому их так любят окружающие.";
                }

                if ((btDATE.Year) % 12 == 7)
                {
                    pbEASTZODIAC.Image = Properties.Resources.Заяц;
                    TBresult.Text += "Вы родились в год кролика" + Environment.NewLine + "Это самые настоящие прагматики, трудолюбивые и ответственные. " +
                        "Эти качества помогают им добиться того образа жизни, к которому они стремятся. Среди большой компании Крыс легко узнать, благодаря своей яркости и прекрасному чувству юмора, поэтому их так любят окружающие.";
                }

                if ((btDATE.Year) % 12 == 8)
                {
                    pbEASTZODIAC.Image = Properties.Resources.Дракон;
                    TBresult.Text += "Вы родились в год дракона" + Environment.NewLine + "Это самые настоящие прагматики, трудолюбивые и ответственные. " +
                        "Эти качества помогают им добиться того образа жизни, к которому они стремятся. Среди большой компании Крыс легко узнать, благодаря своей яркости и прекрасному чувству юмора, поэтому их так любят окружающие.";
                }

                if ((btDATE.Year) % 12 == 9)
                {
                    pbEASTZODIAC.Image = Properties.Resources.Змея;
                    TBresult.Text += "Вы родились в год змеи" + Environment.NewLine + "Это самые настоящие прагматики, трудолюбивые и ответственные. " +
                        "Эти качества помогают им добиться того образа жизни, к которому они стремятся. Среди большой компании Крыс легко узнать, благодаря своей яркости и прекрасному чувству юмора, поэтому их так любят окружающие.";
                }

                if ((btDATE.Year) % 12 == 10)
                {
                    pbEASTZODIAC.Image = Properties.Resources.Лошадь;
                    TBresult.Text += "Вы родились в год лошади" + Environment.NewLine + "Это самые настоящие прагматики, трудолюбивые и ответственные. " +
                        "Эти качества помогают им добиться того образа жизни, к которому они стремятся. Среди большой компании Крыс легко узнать, благодаря своей яркости и прекрасному чувству юмора, поэтому их так любят окружающие.";
                }

                if ((btDATE.Year) % 12 == 11)
                {
                    pbEASTZODIAC.Image = Properties.Resources.Козёл;
                    TBresult.Text += "Вы родились в год козы" + Environment.NewLine + "Это самые настоящие прагматики, трудолюбивые и ответственные. " +
                        "Эти качества помогают им добиться того образа жизни, к которому они стремятся. Среди большой компании Крыс легко узнать, благодаря своей яркости и прекрасному чувству юмора, поэтому их так любят окружающие.";
                }

            // Определение стихии с помощью массива (Пропадает вывод иконки)
            TBresult.Text += Environment.NewLine;
            string[] znaki = { "Земля", "Металл", "Металл", "Вода", "Вода", "Воздух", "Воздух", "Огонь", "Огонь", "Земля" };
            TBresult.Text += "Ваша стихия: " + znaki[btDATE.Year % 1000 % 100 % 10];

        }

        // Кнопочки
        private void PBexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PBhide_Click(object sender, EventArgs e)
        {
            
            if (a % 2 == 0 )
            {
                this.WindowState = FormWindowState.Maximized;
            }

            else
            {
                this.WindowState = FormWindowState.Normal;
            }
            a++;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
