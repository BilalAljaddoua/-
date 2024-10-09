using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace برنامج_اختبار_في_القرآن_الكريم
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (_Counter == 49)
            {
                guna2Button1.PerformClick();
            }
            NextQuestion();
            TurnOffLeds();
       //     btnNext.Enabled = false;
        }
        struct stQuestions
        {
           public string Question;
            public string TrueAnswer;
            public string FalseAnswer1;
            public string FalseAnswer2;
            public string FalseAnswer3;
            public string Reasoning;
        
        }
        private stQuestions[] QuestionsBank()
        {
            stQuestions[] questions = new stQuestions[50 ];

            questions[0].Question = "كيف حدث نزول القرآن الكريم     ";
            questions[0].TrueAnswer = "نزل القرآن الكريم جملة واحدة في ليلة القدر من شهر رمضان من اللوح المحفوظ إلى بيت العزة في السماء الدنيا ";
            questions[0].FalseAnswer1 = " نزل القرآن الكريم جملة واحدة في ليلة الإسراء والمعراج   من اللوح المحفوظ إلى بيت العزة في السماء الدنيا";
            questions[0].FalseAnswer2 = "نزل القرآن الكريم جملة واحدة في ليلة القدر من شهر رجب من اللوح المحفوظ إلى بيت العزة في السماء الدنيا ";
            questions[0].FalseAnswer3 = "نزل القرآن الكريم متفرقاً في ليلة القدر من شهر رمضان من اللوح المحفوظ إلى بيت العزة في السماء الدنيا ";
            questions[0].Reasoning = "نزل القرآن الكريم جملة واحدة في ليلة القدر من شهر رمضان من اللوح المحفوظ إلى بيت\r\nالعزة في السماء الدنيا.\r\nقال الله تعالى: ((إنا أنزلناه في ليلة القدر)) وقال تعالى: ((شهر رمضان الذي أنزل فيه القرآن\r\nهد ًى للناس)) ";

         
            //السؤال رقم     
            questions[1].Question = "للقرآن الكريم عدة تسميات, اذكر أشهرها مع ذكر الدليل عليها ";
            questions[1].TrueAnswer = " كله صحيح";
            questions[1].FalseAnswer1 = "الكتاب: قال الله تعالى: ((كتاب أنزلناه إليك مبارك ليّدبروا آياته وليتذكر ألو الألباب)) ص يعني القرآن ";
            questions[1].FalseAnswer2 = "النور: قال الله تعالى: ((يا أيها الناس قد جاءكم برهان من ربكم وأنزلنا إليكم نواًر مبيناً))  ";
            questions[1].FalseAnswer3 = " الفرقان: قال الله تعالى: ((تبارك الذي نزل الفرقان على عبده ليكون للعالمين نذيرا)) الفرقان4 يعني القرآن";
            questions[1].Reasoning = "ج- الكتاب: قال الله تعالى: ((كتاب أنزلناه إليك مبارك ليّدبروا آياته وليتذكر ألو الألباب))  \r\nيعني القرآن.\r\nالنور: قال الله تعالى: ((يا أيها الناس قد جاءكم برهان من ربكم وأنزلنا إليكم نواًر مبيناً))\r\nالنساء  471يعني القرآن.\r\nالفرقان: قال الله تعالى: ((تبارك الذي نزل الفرقان على عبده ليكون للعالمين نذيرا)) الفرقان4\r\nيعني القرآن ";

            //السؤال رقم     
            questions[2].Question = "ما هو تعريف القرآن الكريم؟";
            questions[2].TrueAnswer = "كله صحيح";
            questions[2].FalseAnswer1 = "  المتعبد بتلاوته, المعجز ولو بسورة منه";
            questions[2].FalseAnswer2 = "المكتوب في المصاحف, المنقول بالتواتر";
            questions[2].FalseAnswer3 = "هو كلام الله تعالى المنزل على النبي محمد صلى الله عليه وسلم بواسطة جبريل عليه السلام";
            questions[2].Reasoning = "التعليل: هو كلام الله تعالى المنزل على النبي محمد صلى الله عليه وسلم بواسطة جبريل عليه السلام, المكتوب في المصاحف, المنقول بالتواتر, المتعبد بتلاوته, المعجز ولو بسورة منه";

            //السؤال رقم     
            questions[3].Question = " كيف كان ينزل القرآن على النبي محمد صلى الله عليه وسلم؟ ";
            questions[3].TrueAnswer = "مُنجماً (مُفرقاً) ";
            questions[3].FalseAnswer1 = " على دفعة واحدة";
            questions[3].FalseAnswer2 = " على دفعتين";
            questions[3].FalseAnswer3 = " على ثلاث دفعات";
            questions[3].Reasoning = " لم ينزل القرآن على النبي محمد صلى الله عليه وسلم دفعة واحدة, وانما نزل منجماً(أي مفرقاً) بحسب المناسبات واقتضاء الحال, وقد استمر نزول القرآن ثلاثاً وعشرين سنة منذ بدء الوحي إلى النبي صلى الله عليه وسلم وهو في سن الأربعين, إلى حين لحق بالرفيق الأعلى في الثالثة والستين من عمره الشريف صلى الله عليه وسلم كما ثبت ذلك في الأحاديث الصحيحة";

            //السؤال رقم     
            questions[4].Question = "ما الحكم من نزول القرآن منجماً على النبي صلى الله عليه وسلم ";
            questions[4].TrueAnswer = " كله صحيح";
            questions[4].FalseAnswer1 = "      تثبيت فؤاد النبي صلى الله عليه وسلم وتقوية قلبه. ";
            questions[4].FalseAnswer2 = "  مواجهة ما يطرأ من حوادث أو أمور تمس الدعوة. ";
            questions[4].FalseAnswer3 = "تعهد هذه الأمة التي أنزل عليها القرآن ";
            questions[4].Reasoning = @"   أولا: تثبيت فؤاد النبي صلى الله عليه وسلم وتقوية قلبه.
قال الله تعالى: ((وقال الذين كفروا لو ُنّزل عليه القرآن جملة واحدة كذلك لنثبت به فؤادك
ورتلناه ترتيلا)).
ثانياً : مواجهة ما يطرأ من حوادث أو أمور تمس الدعوة.
قال الله تعالى: ((ولا يأتونك بمثل إلا جئناك بالحق وأحسن تفسيرا)).
ثالثا: تعهد هذه الأمة التي أنزل عليها القرآن . قال الله تعالى: ((وقرآناً فرقناه لتقرأه على الناس على مكثٍ ونزلناه تنزيلا))
 ";

            //السؤال رقم     
            questions[5].Question = " ماهي أول آية نزلت من القرآن الكريم؟";
            questions[5].TrueAnswer = " صدر سورة العلق";
            questions[5].FalseAnswer1 = " آخر آية في سورة البقرة";
            questions[5].FalseAnswer2 = "أول آية في سورة آل عمران ";
            questions[5].FalseAnswer3 = " آية الكرسي";
            questions[5].Reasoning = "    إن أول ما نزل من القرآن الكريم هو صدر سورة العلق: ((اقرأ باسم ربك الذي خلق * خلق الإنسان من علق * أقرأ وربك الأكرم * الذي علم بالقلم * علم الإنسان ما لم يعلم)";

            //السؤال رقم     
            questions[6].Question = " ماهي آخر آية نزلت من القرآن الكريم؟";
            questions[6].TrueAnswer = "الآية 281 من سورة البقرة ";
            questions[6].FalseAnswer1 = "الآية 30 من سورة النساء ";
            questions[6].FalseAnswer2 = " الآية 10 من سورة التغابن";
            questions[6].FalseAnswer3 = "آية المداينة ";
            questions[6].Reasoning = "إن آخر آية نزلت من القرآن الكريم هي الآية الحادية والثمانون ومائتين من سورة البقرة وهي قوله تعالى):(واتقوا يوماً ترجعون فيه إلى الله ثم توفى كل نفس ما كسبت وهم لا يظلمون).) وقد نزلت قبل وفاة النبي صلى الله عليه وسلم بتسع ليال ";

            //السؤال رقم     
            questions[7].Question = "ماهي أول سورة نزلت بتمامها (دفعة واحدة)؟ ";
            questions[7].TrueAnswer = " سور الفاتحة";
            questions[7].FalseAnswer1 = " سورة آل عمران";
            questions[7].FalseAnswer2 = "سورة الكهف ";
            questions[7].FalseAnswer3 = "سورة البقرة ";
            questions[7].Reasoning = " ";

            //السؤال رقم     
            questions[8].Question = " ماهي آخر سورة نزلت بتمامها (دفعة واحدة)؟";
            questions[8].TrueAnswer = " - سورة النصر (( إذا جاء نصر الله والفتح..........).";
            questions[8].FalseAnswer1 = " الملك";
            questions[8].FalseAnswer2 = " المائدة";
            questions[8].FalseAnswer3 = " الماعون";
            questions[8].Reasoning = " ";

            //السؤال رقم     
            questions[9].Question = " كم عدد سور القرآن الكريم؟";
            questions[9].TrueAnswer = " 114 سورة";
            questions[9].FalseAnswer1 = " 100 سورة";
            questions[9].FalseAnswer2 = " 150 سورة";
            questions[9].FalseAnswer3 = " 200 سورة";
            questions[9].Reasoning = " ";

            //السؤال رقم     
            questions[10].Question = " كم عدد آيات القرآن الكريم؟";
            questions[10].TrueAnswer = " 6236 آية";
            questions[10].FalseAnswer1 = " 6000 آية";
            questions[10].FalseAnswer2 = " 5000 آية";
            questions[10].FalseAnswer3 = " 7000 آية";
            questions[10].Reasoning = " ";

            //السؤال رقم     
            questions[11].Question = " كم عدد أجزاء القرآن الكريم؟";
            questions[11].TrueAnswer = " 30جزءاً";
            questions[11].FalseAnswer1 = " 31 جزءاً";
            questions[11].FalseAnswer2 = " 15 جزءاً";
            questions[11].FalseAnswer3 = " 41 جزءاً";
            questions[11].Reasoning = " ";

            //السؤال رقم     
            questions[12].Question = " كم عدد أحزاب القرآن الكريم؟";
            questions[12].TrueAnswer = " 60 حزباً";
            questions[12].FalseAnswer1 = " 55 حزباً";
            questions[12].FalseAnswer2 = " 65 حزباً";
            questions[12].FalseAnswer3 = " 70 حزباً";
            questions[12].Reasoning = " ";

            //السؤال رقم     
            questions[13].Question = " ما هي أطول سورة في القرآن الكريم؟ وكم عدد آياتها؟";
            questions[13].TrueAnswer = " سورة البقرة وعدد آياتها  286آية";
            questions[13].FalseAnswer1 = " سورة النساء  ";
            questions[13].FalseAnswer2 = " سورة آل عمران  ";
            questions[13].FalseAnswer3 = " سورة المائدة  ";
            questions[13].Reasoning = " ";

            //السؤال رقم     
            questions[14].Question = "ما هي أقصر سورة في القرآن الكريم؟ وكم عدد آياتها؟ ";
            questions[14].TrueAnswer = "سورة الكوثر وعدد آياتها  3آيات ";
            questions[14].FalseAnswer1 = " سورة الفلق  ";
            questions[14].FalseAnswer2 = " سورة الناس  ";
            questions[14].FalseAnswer3 = " سورة الإخلاص  ";
            questions[14].Reasoning = " ";

            //السؤال رقم     
            questions[15].Question = "ما هي السورة التي لم تبدأ بالبسملة؟ ";
            questions[15].TrueAnswer = " سورة التوبة";
            questions[15].FalseAnswer1 = " سورة القارعة";
            questions[15].FalseAnswer2 = " سورة القلم";
            questions[15].FalseAnswer3 = " سورة البروج";
            questions[15].Reasoning = " ";

            //السؤال رقم     
            questions[16].Question = " ما هي السور التي تبدأ بـ ((الحمد لله))";
            questions[16].TrueAnswer = " كله صحيح";
            questions[16].FalseAnswer1 = " سورة الفاتحة, سورة الأنعام";
            questions[16].FalseAnswer2 = " سورة الكهف, سورة سبأ";
            questions[16].FalseAnswer3 = " سورة فاطر";
            questions[16].Reasoning = " ";

            //السؤال رقم     
            questions[17].Question = "السؤال :  من هو الصحابي الذي ذكر اسمه صراحة في القرآن الكريم؟ وفي أي سورة ذكر؟ ";
            questions[17].TrueAnswer = "سيدنا زيد بن حارثة رضي الله عنه, وذكر في سورة الأحزاب ";
            questions[17].FalseAnswer1 = "      سيدنا علي بن أبي طالب رضي الله عنه, وذكر في سورة التوبة";
            questions[17].FalseAnswer2 = " سيدنا عمر بن الخطاب رضي الله عنه, وذكر في سورة الأنفال";
            questions[17].FalseAnswer3 = "سيدنا أبو بكر الصديق رضي الله عنه, وذكر في سورة البقرة ";
            questions[17].Reasoning = " ";

            //السؤال رقم     
            questions[18].Question = " ماهي أطول آية في القرآن الكريم؟";
            questions[18].TrueAnswer = " آية المداينة (الآية من282من سورة البقرة)";
            questions[18].FalseAnswer1 = " آية الكرسي";
            questions[18].FalseAnswer2 = "آية الربا ";
            questions[18].FalseAnswer3 = " آية الصيام";
            questions[18].Reasoning = " ";

            //السؤال رقم     
            questions[19].Question = " كم عدد سجدات التلاوة في القرآن الكريم؟";
            questions[19].TrueAnswer = "15 سجدة ";
            questions[19].FalseAnswer1 = " 20 سجدة";
            questions[19].FalseAnswer2 = "10 سجدة ";
            questions[19].FalseAnswer3 = " 30 سجدة";
            questions[19].Reasoning = " ";

            //السؤال رقم     
            questions[20].Question = " ما هو عدد السور المكية في القرآن الكريم؟";
            questions[20].TrueAnswer = " 87 سورة";
            questions[20].FalseAnswer1 = " 50 سورة";
            questions[20].FalseAnswer2 = "  90 سورة";
            questions[20].FalseAnswer3 = "100 سورة ";
            questions[20].Reasoning = " ";

            //السؤال رقم     
            questions[21].Question = "ما هو عدد السور المدنية في القرآن الكريم؟ ";
            questions[21].TrueAnswer = " 27 سورة";
            questions[21].FalseAnswer1 = "30 سورة ";
            questions[21].FalseAnswer2 = "15 سورة ";
            questions[21].FalseAnswer3 = " 35 سورة";
            questions[21].Reasoning = " ";

            //السؤال رقم     
            questions[22].Question = " من صاحب فكرة جمع القرآن في مصحف واحد؟";
            questions[22].TrueAnswer = " سيدنا عمر بن الخطاب رضي الله عنه";
            questions[22].FalseAnswer1 = " سيدنا علي بن أبي طالب رضي الله عنه";
            questions[22].FalseAnswer2 = "سيدنا عثمان بن عفان رضي الله عنه ";
            questions[22].FalseAnswer3 = "سيدنا أبو بكر الصديق رضي الله عنه ";
            questions[22].Reasoning = " ";

            //السؤال رقم     
            questions[23].Question = " من الذي أمر بجمع القرآن الكريم في مصحف واحد؟";
            questions[23].TrueAnswer = " سيدنا أبو بكر الصديق رضي الله عنه";
            questions[23].FalseAnswer1 = " سيدنا عثمان بن عفان رضي الله عنه";
            questions[23].FalseAnswer2 = " سيدنا علي بن أبي طالب رضي الله عنه";
            questions[23].FalseAnswer3 = "سيدنا عمر بن الخطاب رضي الله عنه ";
            questions[23].Reasoning = " ";

            //السؤال رقم     
            questions[24].Question = " من هو الصحابي الذي تولى جمع القرآن الكريم بأمر من سيدنا أبي بكر رضي الله عنه؟";
            questions[24].TrueAnswer = "سيدنا زيد بن ثابت الأنصاري رضي الله عنه ";
            questions[24].FalseAnswer1 = "سيدنا عبدالله ابن عباس رضي الله عنه ";
            questions[24].FalseAnswer2 = "سيدنا عبدالله ابن عمر رضي الله عنه ";
            questions[24].FalseAnswer3 = "سيدنا بلال الحبشي رضي الله عنه  ";
            questions[24].Reasoning = " ";

            //السؤال رقم     
            questions[25].Question = " من هو الخليفة الذي أمر بنسخ المصحف عدة نسخ لتوزيعها على الأمصار؟";
            questions[25].TrueAnswer = "سيدنا عثمان بن عفان رضي الله عنه ";
            questions[25].FalseAnswer1 = "سيدنا عمر بن الخطاب رضي الله عنه ";
            questions[25].FalseAnswer2 = " سيدنا أبو بكر الصديق رضي الله عنه";
            questions[25].FalseAnswer3 = "سيدنا علي ابن أبي طالب رضي الله عنه ";
            questions[25].Reasoning = " ";

            //السؤال رقم     
            questions[26].Question = " تكفل الله تعالى بحفظ القرآن الكريم بقوله:((إنا نحن نزلنا الذكر وانا له لحافظون)), ما هي الوسائل التي تم بها حفظ القرآن الكريم؟";
            questions[26].TrueAnswer = "كله صحيح ";
            questions[26].FalseAnswer1 = "الحفظ في الصدور: حيث أن النبي صلى الله عليه وسلم حفظ القرآن في صدره والصحابة من بعده ونقلوه إلى من بعدهم وكل جيل نقله إلى من بعده حتى يومنا هذا ";
            questions[26].FalseAnswer2 = "الحفظ في السطور: حيث تم جمع القرآن الكريم وكتابته بمصحف واحد ومن ثم نسخه وبقاءه دون تحريف حتى يومنا هذا ";
            questions[26].FalseAnswer3 = " لاشئ مما سبق";
            questions[26].Reasoning = " ";

            //السؤال رقم     
            questions[27].Question = "اذكر ثلاثة من الصحابة الذين كانوا يكتبون الوحي بين يدي رسول الله صلى الله عليه وسلم؟ ";
            questions[27].TrueAnswer = "كله صحيح ";
            questions[27].FalseAnswer1 = "علي بن أبي طالب رضي الله عنه ";
            questions[27].FalseAnswer2 = " معاوية بن أبي سفيان رضي الله عنه";
            questions[27].FalseAnswer3 = " زيد بن ثابت رضي الله عنه";
            questions[27].Reasoning = " ";

            //السؤال رقم     
            questions[28].Question = " اذكر حديثاً نبوياً يدل على فضل تعلم القرآن الكريم";
            questions[28].TrueAnswer = "   قال رسول الله صلى الله عليه وسلم: ((خيركم من تعلم القرآن وعلمه). ";
            questions[28].FalseAnswer1 = " غير ذلك";
            questions[28].FalseAnswer2 = "لاشئ مما سبق ";
            questions[28].FalseAnswer3 = "كله خاطئ ";
            questions[28].Reasoning = " ";

            //السؤال رقم     
            questions[29].Question = " اذكر حديثاً نبوياً يدل على فضل تلاوة القرآن الكريم";
            questions[29].TrueAnswer = "الجواب الصحيح :  قال رسول الله صلى الله عليه وسلم: ((من ق أر حرفاً من كتاب الله فله به حسنة, والحسنة بعشر أمثالها, لا أقول الم حرف, ولكن ألف حرف, ولام حرف, وميم حرف.) ";
            questions[29].FalseAnswer1 = " غير ذلك";
            questions[29].FalseAnswer2 = " لاشئ مما سبق";
            questions[29].FalseAnswer3 = " كله خاطئ";
            questions[29].Reasoning = " ";

            //السؤال رقم     
            questions[30].Question = "اذكر حديثاً نبوياً يدل على منزلة حافظ القرآن الكريم يوم القيامة ";
            questions[30].TrueAnswer = " قال رسول الله صلى الله عليه وسلم: ((يقال لصاحب القرآن: اقرأ وارق ورتل كما كنت ترتل في الدنيا, فإن منزلتك عند آخر آية تقرؤها).";
            questions[30].FalseAnswer1 = " غير ذلك";
            questions[30].FalseAnswer2 = " لاشئ مما سبق";
            questions[30].FalseAnswer3 = "كله خاطئ ";
            questions[30].Reasoning = " ";

            //السؤال رقم     
            questions[31].Question = " اذكر حديثا نبويا في فضل سورة الفاتحة";
            questions[31].TrueAnswer = " عن أبي هريرة رضي الله عنه عن أبي بن كعب رضي الله عنه قال: قال رسول الله صلى الله عليه وسلم: (( والذي نفسي بيده ما أُنزلت في التوراة , ولا في الإنجيل , ولا في الزبور , ولا في الفرقان مثلها . وانها سبع من المثاني , والقرآن العظيم الذي أعطيته )";
            questions[31].FalseAnswer1 = " غير ذلك";
            questions[31].FalseAnswer2 = " لاشئ مما سبق";
            questions[31].FalseAnswer3 = " كله خاطئ";
            questions[31].Reasoning = " ";

            //السؤال رقم     
            questions[32].Question = " لماذا سميت الفاتحة السبع المثاني ؟";
            questions[32].TrueAnswer = "كله صحيح ";
            questions[32].FalseAnswer1 = " لأنها تثنى في كل ركعة أي تُعاد";
            questions[32].FalseAnswer2 = " أو لأنها ُيثنى بها على الله تعالى";
            questions[32].FalseAnswer3 = " ";
            questions[32].Reasoning = " ";

            //السؤال رقم     
            questions[33].Question = " ما حكم قراءة الفاتحة في الصلاة  ؟";
            questions[33].TrueAnswer = " ركن من أركان الصلاة";
            questions[33].FalseAnswer1 = "سُنة   ";
            questions[33].FalseAnswer2 = " مستحبة  ";
            questions[33].FalseAnswer3 = " مندوبة";
            questions[33].Reasoning = " التعليل:  قراءة الفاتحة ركن من أركان الصلاة ؛ عن عبادة بن الصامت رضي الله عنه قال: قال رسول الله صلى الله عليه وسلم : (( لا صلاة لمن لم يقرأ بفاتحة الكتاب)";

            //السؤال رقم     
            questions[34].Question = " ما هي أعظم آية في القرآن الكريم ؟";
            questions[34].TrueAnswer = " { الله لا إله إلا هو الحي القيوم }";
            questions[34].FalseAnswer1 = " { ألم نشرح لك صدرك }";
            questions[34].FalseAnswer2 = " { إنا أعطيناك الكوثر }";
            questions[34].FalseAnswer3 = " { تبارك الذي بيده الملك ..}";
            questions[34].Reasoning = " عن أبي بن كعب رضي الله عنه قال: قال رسول الله صلى الله عليه وسلم : (( يا أبا المنذر أتدري أي آية من كتاب الله معك أعظم ؟ )) قال: قلت: الله وسوله أعلم. قال : (( يا أبا المنذر أتدري أي آية من كتاب الله معك أعظم ؟ )) قلت: { الله لا إله إلا هو الحي القيوم } قال: فضرب في صدري وقال: (( لَِيهنِ َك العلَم أبا المنذر)). رواه مسلم في صحيحه";

            //السؤال رقم     
            questions[35].Question = " اذكر حديثاً نبوياً في فضل سورة الإخلاص";
            questions[35].TrueAnswer = " الصحيح :  عن أبي سعيد الخدري رضي الله عنه قال: قال النبي صلى الله عليه وسلم لأصحابه: (( أيعجز أحدكم أن يقرأ ثلث القرآن في ليلة ؟ )) فش َّق ذلك عليهم وقالوا : أينا يطيق ذلك يا رسول الله ؟ فقال : (( الله الواحد الصمد ثلث القرآن ).) رواه البخاري في صحيحه";
            questions[35].FalseAnswer1 = "غير ذلك ";
            questions[35].FalseAnswer2 = "لاشئ مما سبق ";
            questions[35].FalseAnswer3 = "كله خاطئ ";
            questions[35].Reasoning = " ";

            //السؤال رقم     
            questions[36].Question = " ماذا يستحب أن يقرأ المصلي في صلاة الوتر؟";
            questions[36].TrueAnswer = " كله صحيح";
            questions[36].FalseAnswer1 = " {قل هو الله أحد }";
            questions[36].FalseAnswer2 = " { قل أعوذ برب الفلق}";
            questions[36].FalseAnswer3 = "{قل أعوذ برب الناس } ";
            questions[36].Reasoning = " عن عائشة رضي الله عنها قالت : كان رسول الله صلى الله عليه وسلم يقرأ في الركعتين اللتين يوتر بعدهما ب { سبح اسم ربك الأعلى } و { قل يا أيها الكافرون } ويقرأ في الوتر { قل هو الله أحد } و { قل أعوذ برب الفلق } و { قل أعوذ برب الناس }";

            //السؤال رقم     
            questions[37].Question = "ماذا يستحب أن يقرأ المصلي في صلاة سنة الفجر؟ ";
            questions[37].TrueAnswer = "{  قل يا أيها الكافرون } و { قل هو الله أحد }. ";
            questions[37].FalseAnswer1 = "{ألم نشرح لك صدرك..} ";
            questions[37].FalseAnswer2 = " {إنا أعطيناك الكوثر..}";
            questions[37].FalseAnswer3 = "{والفجر وليالٍ عشر} ";
            questions[37].Reasoning = " عن أبي هريرة رضي الله عنه أن رسول الله صلى الله عليه وسلم قرأ في ركعتي الفجر: {قل يا أيها الكافرون } و { قل هو الله أحد }. رواه مسلم";

            //السؤال رقم     
            questions[38].Question = " اذكر حديثاً نبوياً في فضل المعوذتين";
            questions[38].TrueAnswer = " عن عقبة بن عامر رضي الله عنه قال: قال رسول الله صلى الله عليه وسلم : (( ألم تر آيات أنزلت الليلة لم ير مثلهن قط ؟ قل أعوذ برب الفلق , وقل أعوذ برب الناس )) رواه مسلم في صحيحه";
            questions[38].FalseAnswer1 = " غير ذلك";
            questions[38].FalseAnswer2 = "لاشئ مما سبق ";
            questions[38].FalseAnswer3 = " كله خاطئ";
            questions[38].Reasoning = " ";

            //السؤال رقم     
            questions[39].Question = " اذكر حديثاً نبوياً في فضل سورة الكافرون";
            questions[39].TrueAnswer = "عن عبدالله بن عمر رضي الله عنه قال: قال رسول الله صلى الله عليه وسلم: (({ قل هو الله أحد } تعدل ثلث القرآن و { قل يا أيها الكافرون } تعدل ربع القرآن , وكان يقرأ بهما في ركعتي الفجر وقال هاتان الركعتان فيهما رغب الدهر)). أي ما يرغب فيهما من الثواب العظيم ولذا سميت ركعتا الفجر بصلاة الرغائب ";
            questions[39].FalseAnswer1 = " غير ذلك";
            questions[39].FalseAnswer2 = " لاشئ مما سبق";
            questions[39].FalseAnswer3 = " كله خاطئ";
            questions[39].Reasoning = " ";

            //السؤال رقم     
            questions[40].Question = " ماهي السورة التي تنفر الشيطان من البيت ؟";
            questions[40].TrueAnswer = " سورة البقرة";
            questions[40].FalseAnswer1 = " سورة النساء";
            questions[40].FalseAnswer2 = " سورة آل عمران";
            questions[40].FalseAnswer3 = "سورة المائدة ";
            questions[40].Reasoning = "عن أبي هريرة رضي الله عنه قال: قال النبي صلى الله عليه وسلم (( لا تجعلوا بيوتكم مقابر . إن الشيطان ينِفر من البيت الذي تُقَأر فيه سورة البقرة )) رواه مسلم ";

            //السؤال رقم     
            questions[41].Question = "ماهي السورة المانعة ولماذا سميت كذلك ؟ ";
            questions[41].TrueAnswer = " المُلك";
            questions[41].FalseAnswer1 = " الحاقة";
            questions[41].FalseAnswer2 = " الأعراف";
            questions[41].FalseAnswer3 = "الأنفال ";
            questions[41].Reasoning = " عن عبد الله بن مسعود رضي الله عنه قال : من قرأ { تبارك الذي بيده الملك } كل ليلة ؛ منعه الله عز وجل بها من عذاب القبر . وكنا في عهد رسول الله نسميها المانعة , وانها في كتاب الله عز وجل سورة من قرأ بها في كل ليلة , فقد أكثر وأطاب";

            //السؤال رقم     
            questions[42].Question = "ماهي الآيات التي تعصم من الدجال ؟ ";
            questions[42].TrueAnswer = " عشر آيات من أول سورة الكهف";
            questions[42].FalseAnswer1 = "عشر آيات من أول سورة البقرة ";
            questions[42].FalseAnswer2 = "عشر آيات من أول سورة الرحمان ";
            questions[42].FalseAnswer3 = "عشر آيات من أول سورة الفرقان ";
            questions[42].Reasoning = " عن أبي الدرداء رضي الله عنه قال: قال رسول الله صلى الله عليه وسلم: (( من حفظ عشر آيات من أول سورة الكهف , عصم من الدجال )) رواه مسلم في صحيحه";

            //السؤال رقم     
            questions[43].Question = " ما هي السورة التي يسن قراءتها يوم الجمعة ؟";
            questions[43].TrueAnswer = " سورة الكهف";
            questions[43].FalseAnswer1 = "سورة الجمعة ";
            questions[43].FalseAnswer2 = " سورة التغابن";
            questions[43].FalseAnswer3 = " سورة يونس";
            questions[43].Reasoning = " عن قيس بن عباد عن أبي سعيد الخدري رضي الله عنه قال: قال رسول الله صلى الله عليه وسلم : (( من قرأ سورة الكهف يوم الجمعة أضاء له من النور ما بينه وبين البيت العتيق)) وفي رواية (أضاء له من النور ما بين الجمعتين))";

            //السؤال رقم     
            questions[44].Question = " ما هي السورة التي هي أحب من الدنيا جميعا ؟";
            questions[44].TrueAnswer = " { إنا فتحنا لك فتحاً مبينا}";
            questions[44].FalseAnswer1 = "{إنا أعطيناك الكوثر}  ";
            questions[44].FalseAnswer2 = "{ ألم نشرح لك صدرك} ";
            questions[44].FalseAnswer3 = "{قل هو الله أحد} ";
            questions[44].Reasoning = "عن عمر بن الخطاب رضي الله عنه قال: قال رسول الله صلى الله عليه وسلم (( لقد أنزلت عل َّي الليلة سورة هي أحب إلي مما طلعت عليه الشمس ثم قرأ ((إنا فتحنا لك فتحاً مبيناً)). رواه البخاري وفي رواية لمسلم عن أنس ((أحب إلي من الدنيا جميعاً) ";

            //السؤال رقم     
            questions[45].Question = "ما هي السور المسبحات ؟ ولماذا سميت كذلك ؟ ";
            questions[45].TrueAnswer = "كله صحيح ";
            questions[45].FalseAnswer1 = " سورة الحديد والحشر";
            questions[45].FalseAnswer2 = "سورة الصف والجمعة ";
            questions[45].FalseAnswer3 = "سورة التغابن والأعلى ";
            questions[45].Reasoning = " سورة الحديد والحشر والصف والجمعة والتغابن والأعلى. وسميت كذلك ؛ لأنها ابتدأت بـ { سبح لله } و { يسبح لله }";

            //السؤال رقم     
            questions[46].Question = " اذكر حديثاً نبوياً في فضل السور المسبحات.";
            questions[46].TrueAnswer = " الصحيح  : عن العرباض بن سارية رضي الله عنه قال (كان النبي صلى الله عليه وسلم يق أر الُمسبِحات قبل أن يرقد ويقول إن فيهن آية أفضل من ألف آية .";
            questions[46].FalseAnswer1 = " غير ذلك";
            questions[46].FalseAnswer2 = "لاشئ مما سبق ";
            questions[46].FalseAnswer3 = "كله خاطئ ";
            questions[46].Reasoning = " ";

            //السؤال رقم     
            questions[47].Question = "ما هي السور التي يسن قراءتها في صلاة الجمعة وصلاة العيدين ؟  ";
            questions[47].TrueAnswer = "   { سبح اسم ربك الأعلى } و { هل أتاك حديث الغاشية";
            questions[47].FalseAnswer1 = "القارعة و الهمزة ";
            questions[47].FalseAnswer2 = " العصر و الفلق";
            questions[47].FalseAnswer3 = " الإخلاص والكوثر";
            questions[47].Reasoning = " عن النعمان بن بشير رضي الله عنهما أن النبي صلى الله عليه وسلم كان يقرأ في العيدين والجمعة بـ { سبح اسم ربك الأعلى } و { هل أتاك حديث الغاشية } ";

            //السؤال رقم     
            questions[48].Question = " ما هي السور التي يسن قراءتها في فجر صلاة الجمعة؟";
            questions[48].TrueAnswer = "  {   ألم تنزيل } السجدة و { هل أتى على الإنسان }";
            questions[48].FalseAnswer1 = "الفلق والناس ";
            questions[48].FalseAnswer2 = "الإخلاص والقارعة ";
            questions[48].FalseAnswer3 = " الفجر والبلد";
            questions[48].Reasoning = " عن أبي هريرة رضي الله عنه قال: كان النبي صلى الله عليه وسلم يقرأ في الجمعة , في صلاة الفجر : { ألم تنزيل } السجدة و { هل أتى على الإنسان } متفق عليه";

            //السؤال رقم     
            questions[49].Question = " ماهي السور التي كان النبي صلى الله عليه وسلم يقرأها قبل النوم ؟";
            questions[49].TrueAnswer = " بني إسرائيل , والزمر";
            questions[49].FalseAnswer1 = " البقرة";
            questions[49].FalseAnswer2 = " آل عمران";
            questions[49].FalseAnswer3 = " النساء";
            questions[49].Reasoning = "عن عائشة رضي الله عنها قالت: كان النبي صلى الله عليه وسلم لا ينام حتى يقرأ بني إسرائيل , والزمر ";



            return questions;


        }

        private stQuestions[] _Questions;
        private int _Counter = 0;
        private bool IsTrue = false;
        private int NumberofTrues = 0;
        private int NumberofFalses = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            _Questions = QuestionsBank();
            stQuestions questions = _Questions[0];
            lblQuostion.Text = questions.Question;
            btnChooice1.Text = questions.TrueAnswer;
            btnChooice2.Text = questions.FalseAnswer1;
            btnChooice3.Text = questions.FalseAnswer2;
            btnChooice4.Text = questions.FalseAnswer3;
        }

        private void NextQuestion()
        {
            btnNumberOfQuestion.Text=(_Counter+2).ToString();
            _Counter++;
            stQuestions questions = _Questions[_Counter];
            lblQuostion.Text = questions.Question;
            btnChooice1.Text = questions.TrueAnswer;
            btnChooice2.Text = questions.FalseAnswer1;
            btnChooice3.Text = questions.FalseAnswer2;
            btnChooice4.Text = questions.FalseAnswer3;
            Chang();


        }
        private void Chang()
        {

            Point Temp = new Point();
            Random random = new Random();
            int randomNumber = random.Next(0, 5);
            Point FirstPoint=Chooice1.Location;
      
        
            if(btnChooice1.Text.Trim().IndexOf("صحيح")>0)
            {
                Point Tempp = Chooice1.Location;
                Chooice1.Location =Chooice4.Location;
                Chooice4.Location = Tempp;
            }
            else if (btnChooice2.Text.Trim().IndexOf("صحيح") > 0)
            {
                Point Tempp = Chooice2.Location;

                Chooice2.Location = Chooice4.Location;
                Chooice4.Location = Tempp;
            }
            else if (btnChooice3.Text.Trim().IndexOf("صحيح") > 0)
            {
                Point Tempp = Chooice3.Location;

                Chooice3.Location = Chooice4.Location;
                Chooice4.Location = Tempp;

            }
            else if (btnChooice4.Text.Trim().IndexOf("صحيح") > 0 )
            {
 
            }
            else
            {
                switch (randomNumber)
                {
                    case 1:
                        {
                            Temp = Chooice1.Location;
                            Chooice1.Location = Chooice2.Location;
                            Chooice2.Location = Temp;
                            break;
                        }
                    case 2:
                        {
                            Temp = Chooice1.Location;
                            Chooice1.Location = Chooice3.Location;
                            Chooice3.Location = Temp;
                            break;
                        }
                    case 3:
                        {
                            Temp = Chooice1.Location;
                            Chooice1.Location = Chooice4.Location;
                            Chooice4.Location = Temp;
                            break;
                        }
                    case 4:
                        {
                            Chooice1.Location = FirstPoint;

                            break;
                        }

                }

            }

        }

        private void btnChooice1_Click(object sender, EventArgs e)
        {
            IsTrue = true;
            btnLed1.FillColor = Color.Yellow;
            btnLed2.FillColor = Color.Black;
            btnLed3.FillColor = Color.Black;
            btnLed4.FillColor = Color.Black;
            btnChooice1.FillColor = Color.Yellow;
            btnChooice2.FillColor = Color.RoyalBlue ;
            btnChooice3.FillColor = Color.RoyalBlue;
            btnChooice4.FillColor = Color.RoyalBlue;

            btnCorrect.Enabled = true;
        }

        private void btnChooice2_Click(object sender, EventArgs e)
        {
            IsTrue = false;
            btnLed1.FillColor = Color.Black;
            btnLed2.FillColor = Color.Yellow;
            btnLed3.FillColor = Color.Black;
            btnLed4.FillColor = Color.Black;
            btnChooice1.FillColor = Color.RoyalBlue;
            btnChooice2.FillColor = Color.Yellow;
            btnChooice3.FillColor = Color.RoyalBlue;
            btnChooice4.FillColor = Color.RoyalBlue;
            btnCorrect.Enabled = true;

        }

        private void btnChooice3_Click(object sender, EventArgs e)
        {
            IsTrue = false;
            btnLed1.FillColor = Color.Black;
            btnLed2.FillColor = Color.Black;
            btnLed3.FillColor = Color.Yellow;
            btnLed4.FillColor = Color.Black;
            btnChooice1.FillColor = Color.RoyalBlue;
            btnChooice2.FillColor = Color.RoyalBlue;
            btnChooice3.FillColor = Color.Yellow;
            btnChooice4.FillColor = Color.RoyalBlue;
            btnCorrect.Enabled = true;

        }

        private void btnChooice4_Click(object sender, EventArgs e)
        {
            IsTrue = false;
            btnLed1.FillColor = Color.Black;
            btnLed2.FillColor = Color.Black;
            btnLed3.FillColor = Color.Black;
            btnLed4.FillColor = Color.Yellow;
            btnChooice1.FillColor = Color.RoyalBlue;
            btnChooice2.FillColor = Color.RoyalBlue;
            btnChooice3.FillColor = Color.RoyalBlue;
            btnChooice4.FillColor = Color.Yellow;
            btnCorrect.Enabled = true;


        }
        private  void TurnOffLeds()
        {
            btnLed1.FillColor = Color.Black;
            btnLed2.FillColor = Color.Black;
            btnLed3.FillColor = Color.Black;
            btnLed4.FillColor = Color.Black;
            btnChooice1.FillColor = Color.RoyalBlue;
            btnChooice2.FillColor = Color.RoyalBlue;
            btnChooice3.FillColor = Color.RoyalBlue;
            btnChooice4.FillColor = Color.RoyalBlue;

        }

        private void btnLed3_Click(object sender, EventArgs e)
        {

        }

        private void btnCorrect_Click_1(object sender, EventArgs e)
        { 
            btnLed1.FillColor= Color.LightGreen;
            btnChooice1.FillColor= Color.LightGreen;
            btnNext.Enabled = true;

            if (IsTrue)
            {
                MessageBox.Show("إجابة صحيحة","أحسنت",MessageBoxButtons.OK,MessageBoxIcon.Information);
                NumberofTrues++;
            }
            else
            {
                MessageBox.Show("إجابة خاطئة", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                NumberofFalses++;
            }
            if ((_Questions[_Counter].Reasoning)!=" ")
            {
                frmShowInfocs frmShow = new frmShowInfocs(_Questions[_Counter].Reasoning);
                frmShow.ShowDialog();
            }
            btnCorrect.Enabled = false;
         }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            frmResult frmResult=new frmResult(NumberofTrues,NumberofFalses);
            frmResult.ShowDialog();
            this.Close();
        }
    }
}
