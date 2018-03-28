using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;
using System.Threading;

namespace NewBellSchedule
{
    public partial class Form1 : Form
    {
        TextBox[] input_jam = new TextBox[60];
        TextBox[] input_menit = new TextBox[60];
        TextBox[] input_detik = new TextBox[60];
        TextBox[] input_durasi = new TextBox[60];
        CheckBox[] input_senin = new CheckBox[60];
        CheckBox[] input_selasa = new CheckBox[60];
        CheckBox[] input_rabu = new CheckBox[60];
        CheckBox[] input_kamis = new CheckBox[60];
        CheckBox[] input_jumat = new CheckBox[60];
        CheckBox[] input_sabtu = new CheckBox[60];
        CheckBox[] input_minggu = new CheckBox[60];
        TextBox[] input_ip = new TextBox[12];
        string[] simpan, saveip;
        string dataHari,addBell;
        static string direktori = Application.StartupPath.ToString();
        string dataBell = direktori + "\\DataBell.txt";
        string ipConfig = direktori + "\\IpConfig.txt";

        public Form1()
        {
            InitializeComponent();
        }

        private void setSenin (CheckBox[] input_senin)
        {
            input_senin[0] = cb_senin1;
            input_senin[1] = cb_senin2;
            input_senin[2] = cb_senin3;
            input_senin[3] = cb_senin4;
            input_senin[4] = cb_senin5;
            input_senin[5] = cb_senin6;
            input_senin[6] = cb_senin7;
            input_senin[7] = cb_senin8;
            input_senin[8] = cb_senin9;
            input_senin[9] = cb_senin10;
            input_senin[10] = cb_senin11;
            input_senin[11] = cb_senin12;
            input_senin[12] = cb_senin13;
            input_senin[13] = cb_senin14;
            input_senin[14] = cb_senin15;
            input_senin[15] = cb_senin16;
            input_senin[16] = cb_senin17;
            input_senin[17] = cb_senin18;
            input_senin[18] = cb_senin19;
            input_senin[19] = cb_senin20;
            input_senin[20] = cb_senin21;
            input_senin[21] = cb_senin22;
            input_senin[22] = cb_senin23;
            input_senin[23] = cb_senin24;
            input_senin[24] = cb_senin25;
            input_senin[25] = cb_senin26;
            input_senin[26] = cb_senin27;
            input_senin[27] = cb_senin28;
            input_senin[28] = cb_senin29;
            input_senin[29] = cb_senin30;
            input_senin[30] = cb_senin31;
            input_senin[31] = cb_senin32;
            input_senin[32] = cb_senin33;
            input_senin[33] = cb_senin34;
            input_senin[34] = cb_senin35;
            input_senin[35] = cb_senin36;
            input_senin[36] = cb_senin37;
            input_senin[37] = cb_senin38;
            input_senin[38] = cb_senin39;
            input_senin[39] = cb_senin40;
            input_senin[40] = cb_senin41;
            input_senin[41] = cb_senin42;
            input_senin[42] = cb_senin43;
            input_senin[43] = cb_senin44;
            input_senin[44] = cb_senin45;
            input_senin[45] = cb_senin46;
            input_senin[46] = cb_senin47;
            input_senin[47] = cb_senin48;
            input_senin[48] = cb_senin49;
            input_senin[49] = cb_senin50;
            input_senin[50] = cb_senin51;
            input_senin[51] = cb_senin52;
            input_senin[52] = cb_senin53;
            input_senin[53] = cb_senin54;
            input_senin[54] = cb_senin55;
            input_senin[55] = cb_senin56;
            input_senin[56] = cb_senin57;
            input_senin[57] = cb_senin58;
            input_senin[58] = cb_senin59;
            input_senin[59] = cb_senin60;
        }

        private void setSelasa (CheckBox[] input_selasa)
        {
            input_selasa[0] = cb_selasa1;
            input_selasa[1] = cb_selasa2;
            input_selasa[2] = cb_selasa3;
            input_selasa[3] = cb_selasa4;
            input_selasa[4] = cb_selasa5;
            input_selasa[5] = cb_selasa6;
            input_selasa[6] = cb_selasa7;
            input_selasa[7] = cb_selasa8;
            input_selasa[8] = cb_selasa9;
            input_selasa[9] = cb_selasa10;
            input_selasa[10] = cb_selasa11;
            input_selasa[11] = cb_selasa12;
            input_selasa[12] = cb_selasa13;
            input_selasa[13] = cb_selasa14;
            input_selasa[14] = cb_selasa15;
            input_selasa[15] = cb_selasa16;
            input_selasa[16] = cb_selasa17;
            input_selasa[17] = cb_selasa18;
            input_selasa[18] = cb_selasa19;
            input_selasa[19] = cb_selasa20;
            input_selasa[20] = cb_selasa21;
            input_selasa[21] = cb_selasa22;
            input_selasa[22] = cb_selasa23;
            input_selasa[23] = cb_selasa24;
            input_selasa[24] = cb_selasa25;
            input_selasa[25] = cb_selasa26;
            input_selasa[26] = cb_selasa27;
            input_selasa[27] = cb_selasa28;
            input_selasa[28] = cb_selasa29;
            input_selasa[29] = cb_selasa30;
            input_selasa[30] = cb_selasa31;
            input_selasa[31] = cb_selasa32;
            input_selasa[32] = cb_selasa33;
            input_selasa[33] = cb_selasa34;
            input_selasa[34] = cb_selasa35;
            input_selasa[35] = cb_selasa36;
            input_selasa[36] = cb_selasa37;
            input_selasa[37] = cb_selasa38;
            input_selasa[38] = cb_selasa39;
            input_selasa[39] = cb_selasa40;
            input_selasa[40] = cb_selasa41;
            input_selasa[41] = cb_selasa42;
            input_selasa[42] = cb_selasa43;
            input_selasa[43] = cb_selasa44;
            input_selasa[44] = cb_selasa45;
            input_selasa[45] = cb_selasa46;
            input_selasa[46] = cb_selasa47;
            input_selasa[47] = cb_selasa48;
            input_selasa[48] = cb_selasa49;
            input_selasa[49] = cb_selasa50;
            input_selasa[50] = cb_selasa51;
            input_selasa[51] = cb_selasa52;
            input_selasa[52] = cb_selasa53;
            input_selasa[53] = cb_selasa54;
            input_selasa[54] = cb_selasa55;
            input_selasa[55] = cb_selasa56;
            input_selasa[56] = cb_selasa57;
            input_selasa[57] = cb_selasa58;
            input_selasa[58] = cb_selasa59;
            input_selasa[59] = cb_selasa60;
        }

        private void setRabu (CheckBox[] input_rabu)
        {
            input_rabu[0] = cb_rabu1;
            input_rabu[1] = cb_rabu2;
            input_rabu[2] = cb_rabu3;
            input_rabu[3] = cb_rabu4;
            input_rabu[4] = cb_rabu5;
            input_rabu[5] = cb_rabu6;
            input_rabu[6] = cb_rabu7;
            input_rabu[7] = cb_rabu8;
            input_rabu[8] = cb_rabu9;
            input_rabu[9] = cb_rabu10;
            input_rabu[10] = cb_rabu11;
            input_rabu[11] = cb_rabu12;
            input_rabu[12] = cb_rabu13;
            input_rabu[13] = cb_rabu14;
            input_rabu[14] = cb_rabu15;
            input_rabu[15] = cb_rabu16;
            input_rabu[16] = cb_rabu17;
            input_rabu[17] = cb_rabu18;
            input_rabu[18] = cb_rabu19;
            input_rabu[19] = cb_rabu20;
            input_rabu[20] = cb_rabu21;
            input_rabu[21] = cb_rabu22;
            input_rabu[22] = cb_rabu23;
            input_rabu[23] = cb_rabu24;
            input_rabu[24] = cb_rabu25;
            input_rabu[25] = cb_rabu26;
            input_rabu[26] = cb_rabu27;
            input_rabu[27] = cb_rabu28;
            input_rabu[28] = cb_rabu29;
            input_rabu[29] = cb_rabu30;
            input_rabu[30] = cb_rabu31;
            input_rabu[31] = cb_rabu32;
            input_rabu[32] = cb_rabu33;
            input_rabu[33] = cb_rabu34;
            input_rabu[34] = cb_rabu35;
            input_rabu[35] = cb_rabu36;
            input_rabu[36] = cb_rabu37;
            input_rabu[37] = cb_rabu38;
            input_rabu[38] = cb_rabu39;
            input_rabu[39] = cb_rabu40;
            input_rabu[40] = cb_rabu41;
            input_rabu[41] = cb_rabu42;
            input_rabu[42] = cb_rabu43;
            input_rabu[43] = cb_rabu44;
            input_rabu[44] = cb_rabu45;
            input_rabu[45] = cb_rabu46;
            input_rabu[46] = cb_rabu47;
            input_rabu[47] = cb_rabu48;
            input_rabu[48] = cb_rabu49;
            input_rabu[49] = cb_rabu50;
            input_rabu[50] = cb_rabu51;
            input_rabu[51] = cb_rabu52;
            input_rabu[52] = cb_rabu53;
            input_rabu[53] = cb_rabu54;
            input_rabu[54] = cb_rabu55;
            input_rabu[55] = cb_rabu56;
            input_rabu[56] = cb_rabu57;
            input_rabu[57] = cb_rabu58;
            input_rabu[58] = cb_rabu59;
            input_rabu[59] = cb_rabu60;
        }

        private void setKamis (CheckBox[] input_kamis)
        {
            input_kamis[0] = cb_kamis1;
            input_kamis[1] = cb_kamis2;
            input_kamis[2] = cb_kamis3;
            input_kamis[3] = cb_kamis4;
            input_kamis[4] = cb_kamis5;
            input_kamis[5] = cb_kamis6;
            input_kamis[6] = cb_kamis7;
            input_kamis[7] = cb_kamis8;
            input_kamis[8] = cb_kamis9;
            input_kamis[9] = cb_kamis10;
            input_kamis[10] = cb_kamis11;
            input_kamis[11] = cb_kamis12;
            input_kamis[12] = cb_kamis13;
            input_kamis[13] = cb_kamis14;
            input_kamis[14] = cb_kamis15;
            input_kamis[15] = cb_kamis16;
            input_kamis[16] = cb_kamis17;
            input_kamis[17] = cb_kamis18;
            input_kamis[18] = cb_kamis19;
            input_kamis[19] = cb_kamis20;
            input_kamis[20] = cb_kamis21;
            input_kamis[21] = cb_kamis22;
            input_kamis[22] = cb_kamis23;
            input_kamis[23] = cb_kamis24;
            input_kamis[24] = cb_kamis25;
            input_kamis[25] = cb_kamis26;
            input_kamis[26] = cb_kamis27;
            input_kamis[27] = cb_kamis28;
            input_kamis[28] = cb_kamis29;
            input_kamis[29] = cb_kamis30;
            input_kamis[30] = cb_kamis31;
            input_kamis[31] = cb_kamis32;
            input_kamis[32] = cb_kamis33;
            input_kamis[33] = cb_kamis34;
            input_kamis[34] = cb_kamis35;
            input_kamis[35] = cb_kamis36;
            input_kamis[36] = cb_kamis37;
            input_kamis[37] = cb_kamis38;
            input_kamis[38] = cb_kamis39;
            input_kamis[39] = cb_kamis40;
            input_kamis[40] = cb_kamis41;
            input_kamis[41] = cb_kamis42;
            input_kamis[42] = cb_kamis43;
            input_kamis[43] = cb_kamis44;
            input_kamis[44] = cb_kamis45;
            input_kamis[45] = cb_kamis46;
            input_kamis[46] = cb_kamis47;
            input_kamis[47] = cb_kamis48;
            input_kamis[48] = cb_kamis49;
            input_kamis[49] = cb_kamis50;
            input_kamis[50] = cb_kamis51;
            input_kamis[51] = cb_kamis52;
            input_kamis[52] = cb_kamis53;
            input_kamis[53] = cb_kamis54;
            input_kamis[54] = cb_kamis55;
            input_kamis[55] = cb_kamis56;
            input_kamis[56] = cb_kamis57;
            input_kamis[57] = cb_kamis58;
            input_kamis[58] = cb_kamis59;
            input_kamis[59] = cb_kamis60;
        }

        private void setJumat (CheckBox[] input_jumat)
        {
            input_jumat[0] = cb_jumat1;
            input_jumat[1] = cb_jumat2;
            input_jumat[2] = cb_jumat3;
            input_jumat[3] = cb_jumat4;
            input_jumat[4] = cb_jumat5;
            input_jumat[5] = cb_jumat6;
            input_jumat[6] = cb_jumat7;
            input_jumat[7] = cb_jumat8;
            input_jumat[8] = cb_jumat9;
            input_jumat[9] = cb_jumat10;
            input_jumat[10] = cb_jumat11;
            input_jumat[11] = cb_jumat12;
            input_jumat[12] = cb_jumat13;
            input_jumat[13] = cb_jumat14;
            input_jumat[14] = cb_jumat15;
            input_jumat[15] = cb_jumat16;
            input_jumat[16] = cb_jumat17;
            input_jumat[17] = cb_jumat18;
            input_jumat[18] = cb_jumat19;
            input_jumat[19] = cb_jumat20;
            input_jumat[20] = cb_jumat21;
            input_jumat[21] = cb_jumat22;
            input_jumat[22] = cb_jumat23;
            input_jumat[23] = cb_jumat24;
            input_jumat[24] = cb_jumat25;
            input_jumat[25] = cb_jumat26;
            input_jumat[26] = cb_jumat27;
            input_jumat[27] = cb_jumat28;
            input_jumat[28] = cb_jumat29;
            input_jumat[29] = cb_jumat30;
            input_jumat[30] = cb_jumat31;
            input_jumat[31] = cb_jumat32;
            input_jumat[32] = cb_jumat33;
            input_jumat[33] = cb_jumat34;
            input_jumat[34] = cb_jumat35;
            input_jumat[35] = cb_jumat36;
            input_jumat[36] = cb_jumat37;
            input_jumat[37] = cb_jumat38;
            input_jumat[38] = cb_jumat39;
            input_jumat[39] = cb_jumat40;
            input_jumat[40] = cb_jumat41;
            input_jumat[41] = cb_jumat42;
            input_jumat[42] = cb_jumat43;
            input_jumat[43] = cb_jumat44;
            input_jumat[44] = cb_jumat45;
            input_jumat[45] = cb_jumat46;
            input_jumat[46] = cb_jumat47;
            input_jumat[47] = cb_jumat48;
            input_jumat[48] = cb_jumat49;
            input_jumat[49] = cb_jumat50;
            input_jumat[50] = cb_jumat51;
            input_jumat[51] = cb_jumat52;
            input_jumat[52] = cb_jumat53;
            input_jumat[53] = cb_jumat54;
            input_jumat[54] = cb_jumat55;
            input_jumat[55] = cb_jumat56;
            input_jumat[56] = cb_jumat57;
            input_jumat[57] = cb_jumat58;
            input_jumat[58] = cb_jumat59;
            input_jumat[59] = cb_jumat60;
        }

        private void setSabtu (CheckBox[] input_sabtu)
        {
            input_sabtu[0] = cb_sabtu1;
            input_sabtu[1] = cb_sabtu2;
            input_sabtu[2] = cb_sabtu3;
            input_sabtu[3] = cb_sabtu4;
            input_sabtu[4] = cb_sabtu5;
            input_sabtu[5] = cb_sabtu6;
            input_sabtu[6] = cb_sabtu7;
            input_sabtu[7] = cb_sabtu8;
            input_sabtu[8] = cb_sabtu9;
            input_sabtu[9] = cb_sabtu10;
            input_sabtu[10] = cb_sabtu11;
            input_sabtu[11] = cb_sabtu12;
            input_sabtu[12] = cb_sabtu13;
            input_sabtu[13] = cb_sabtu14;
            input_sabtu[14] = cb_sabtu15;
            input_sabtu[15] = cb_sabtu16;
            input_sabtu[16] = cb_sabtu17;
            input_sabtu[17] = cb_sabtu18;
            input_sabtu[18] = cb_sabtu19;
            input_sabtu[19] = cb_sabtu20;
            input_sabtu[20] = cb_sabtu21;
            input_sabtu[21] = cb_sabtu22;
            input_sabtu[22] = cb_sabtu23;
            input_sabtu[23] = cb_sabtu24;
            input_sabtu[24] = cb_sabtu25;
            input_sabtu[25] = cb_sabtu26;
            input_sabtu[26] = cb_sabtu27;
            input_sabtu[27] = cb_sabtu28;
            input_sabtu[28] = cb_sabtu29;
            input_sabtu[29] = cb_sabtu30;
            input_sabtu[30] = cb_sabtu31;
            input_sabtu[31] = cb_sabtu32;
            input_sabtu[32] = cb_sabtu33;
            input_sabtu[33] = cb_sabtu34;
            input_sabtu[34] = cb_sabtu35;
            input_sabtu[35] = cb_sabtu36;
            input_sabtu[36] = cb_sabtu37;
            input_sabtu[37] = cb_sabtu38;
            input_sabtu[38] = cb_sabtu39;
            input_sabtu[39] = cb_sabtu40;
            input_sabtu[40] = cb_sabtu41;
            input_sabtu[41] = cb_sabtu42;
            input_sabtu[42] = cb_sabtu43;
            input_sabtu[43] = cb_sabtu44;
            input_sabtu[44] = cb_sabtu45;
            input_sabtu[45] = cb_sabtu46;
            input_sabtu[46] = cb_sabtu47;
            input_sabtu[47] = cb_sabtu48;
            input_sabtu[48] = cb_sabtu49;
            input_sabtu[49] = cb_sabtu50;
            input_sabtu[50] = cb_sabtu51;
            input_sabtu[51] = cb_sabtu52;
            input_sabtu[52] = cb_sabtu53;
            input_sabtu[53] = cb_sabtu54;
            input_sabtu[54] = cb_sabtu55;
            input_sabtu[55] = cb_sabtu56;
            input_sabtu[56] = cb_sabtu57;
            input_sabtu[57] = cb_sabtu58;
            input_sabtu[58] = cb_sabtu59;
            input_sabtu[59] = checkBox297;
        }

        private void setMinggu (CheckBox[] input_minggu)
        {
            input_minggu[0] = cb_minggu1;
            input_minggu[1] = cb_minggu2;
            input_minggu[2] = cb_minggu3;
            input_minggu[3] = cb_minggu4;
            input_minggu[4] = cb_minggu5;
            input_minggu[5] = cb_minggu6;
            input_minggu[6] = cb_minggu7;
            input_minggu[7] = cb_minggu8;
            input_minggu[8] = cb_minggu9;
            input_minggu[9] = cb_minggu10;
            input_minggu[10] = cb_minggu11;
            input_minggu[11] = cb_minggu12;
            input_minggu[12] = cb_minggu13;
            input_minggu[13] = cb_minggu14;
            input_minggu[14] = cb_minggu15;
            input_minggu[15] = cb_minggu16;
            input_minggu[16] = cb_minggu17;
            input_minggu[17] = cb_minggu18;
            input_minggu[18] = cb_minggu19;
            input_minggu[19] = cb_minggu20;
            input_minggu[20] = cb_minggu21;
            input_minggu[21] = cb_minggu22;
            input_minggu[22] = cb_minggu23;
            input_minggu[23] = cb_minggu24;
            input_minggu[24] = cb_minggu25;
            input_minggu[25] = cb_minggu26;
            input_minggu[26] = cb_minggu27;
            input_minggu[27] = cb_minggu28;
            input_minggu[28] = cb_minggu29;
            input_minggu[29] = cb_minggu30;
            input_minggu[30] = cb_minggu31;
            input_minggu[31] = cb_minggu32;
            input_minggu[32] = cb_minggu33;
            input_minggu[33] = cb_minggu34;
            input_minggu[34] = cb_minggu35;
            input_minggu[35] = cb_minggu36;
            input_minggu[36] = cb_minggu37;
            input_minggu[37] = cb_minggu38;
            input_minggu[38] = cb_minggu39;
            input_minggu[39] = cb_minggu40;
            input_minggu[40] = cb_minggu41;
            input_minggu[41] = cb_minggu42;
            input_minggu[42] = cb_minggu43;
            input_minggu[43] = cb_minggu44;
            input_minggu[44] = cb_minggu45;
            input_minggu[45] = cb_minggu46;
            input_minggu[46] = cb_minggu47;
            input_minggu[47] = cb_minggu48;
            input_minggu[48] = cb_minggu49;
            input_minggu[49] = cb_minggu50;
            input_minggu[50] = cb_minggu51;
            input_minggu[51] = cb_minggu52;
            input_minggu[52] = cb_minggu53;
            input_minggu[53] = cb_minggu54;
            input_minggu[54] = cb_minggu55;
            input_minggu[55] = cb_minggu56;
            input_minggu[56] = cb_minggu57;
            input_minggu[57] = cb_minggu58;
            input_minggu[58] = cb_minggu59;
            input_minggu[59] = cb_minggu60;
        }

        private void setJam(TextBox[] input_jam)
        {
            input_jam[0] = tb_injam1;
            input_jam[1] = tb_injam2;
            input_jam[2] = tb_injam3;
            input_jam[3] = tb_injam4;
            input_jam[4] = tb_injam5;
            input_jam[5] = tb_injam6;
            input_jam[6] = tb_injam7;
            input_jam[7] = tb_injam8;
            input_jam[8] = tb_injam9;
            input_jam[9] = tb_injam10;
            input_jam[10] = tb_injam11;
            input_jam[11] = tb_injam12;
            input_jam[12] = tb_injam13;
            input_jam[13] = tb_injam14;
            input_jam[14] = tb_injam15;
            input_jam[15] = tb_injam16;
            input_jam[16] = tb_injam17;
            input_jam[17] = tb_injam18;
            input_jam[18] = tb_injam19;
            input_jam[19] = tb_injam20;
            input_jam[20] = tb_injam21;
            input_jam[21] = tb_injam22;
            input_jam[22] = tb_injam23;
            input_jam[23] = tb_injam24;
            input_jam[24] = tb_injam25;
            input_jam[25] = tb_injam26;
            input_jam[26] = tb_injam27;
            input_jam[27] = tb_injam28;
            input_jam[28] = tb_injam29;
            input_jam[29] = tb_injam30;
            input_jam[30] = tb_injam31;
            input_jam[31] = tb_injam32;
            input_jam[32] = tb_injam33;
            input_jam[33] = tb_injam34;
            input_jam[34] = tb_injam35;
            input_jam[35] = tb_injam36;
            input_jam[36] = tb_injam37;
            input_jam[37] = tb_injam38;
            input_jam[38] = tb_injam39;
            input_jam[39] = tb_injam40;
            input_jam[40] = tb_injam41;
            input_jam[41] = tb_injam42;
            input_jam[42] = tb_injam43;
            input_jam[43] = tb_injam44;
            input_jam[44] = tb_injam45;
            input_jam[45] = tb_injam46;
            input_jam[46] = tb_injam47;
            input_jam[47] = tb_injam48;
            input_jam[48] = tb_injam49;
            input_jam[49] = tb_injam50;
            input_jam[50] = tb_injam51;
            input_jam[51] = tb_injam52;
            input_jam[52] = tb_injam53;
            input_jam[53] = tb_injam54;
            input_jam[54] = tb_injam55;
            input_jam[55] = tb_injam56;
            input_jam[56] = tb_injam57;
            input_jam[57] = tb_injam58;
            input_jam[58] = tb_injam59;
            input_jam[59] = tb_injam60;

        }

        private void setMenit(TextBox[] input_menit)
        {
            input_menit[0] = tb_inmenit1;
            input_menit[1] = tb_inmenit2;
            input_menit[2] = tb_inmenit3;
            input_menit[3] = tb_inmenit4;
            input_menit[4] = tb_inmenit5;
            input_menit[5] = tb_inmenit6;
            input_menit[6] = tb_inmenit7;
            input_menit[7] = tb_inmenit8;
            input_menit[8] = tb_inmenit9;
            input_menit[9] = tb_inmenit10;
            input_menit[10] = tb_inmenit11;
            input_menit[11] = tb_inmenit12;
            input_menit[12] = tb_inmenit13;
            input_menit[13] = tb_inmenit14;
            input_menit[14] = tb_inmenit15;
            input_menit[15] = tb_inmenit16;
            input_menit[16] = tb_inmenit17;
            input_menit[17] = tb_inmenit18;
            input_menit[18] = tb_inmenit19;
            input_menit[19] = tb_inmenit20;
            input_menit[20] = tb_inmenit21;
            input_menit[21] = tb_inmenit22;
            input_menit[22] = tb_inmenit23;
            input_menit[23] = tb_inmenit24;
            input_menit[24] = tb_inmenit25;
            input_menit[25] = tb_inmenit26;
            input_menit[26] = tb_inmenit27;
            input_menit[27] = tb_inmenit28;
            input_menit[28] = tb_inmenit29;
            input_menit[29] = tb_inmenit30;
            input_menit[30] = tb_inmenit31;
            input_menit[31] = tb_inmenit32;
            input_menit[32] = tb_inmenit33;
            input_menit[33] = tb_inmenit34;
            input_menit[34] = tb_inmenit35;
            input_menit[35] = tb_inmenit36;
            input_menit[36] = tb_inmenit37;
            input_menit[37] = tb_inmenit38;
            input_menit[38] = tb_inmenit39;
            input_menit[39] = tb_inmenit40;
            input_menit[40] = tb_inmenit41;
            input_menit[41] = tb_inmenit42;
            input_menit[42] = tb_inmenit43;
            input_menit[43] = tb_inmenit44;
            input_menit[44] = tb_inmenit45;
            input_menit[45] = tb_inmenit46;
            input_menit[46] = tb_inmenit47;
            input_menit[47] = tb_inmenit48;
            input_menit[48] = tb_inmenit49;
            input_menit[49] = tb_inmenit50;
            input_menit[50] = tb_inmenit51;
            input_menit[51] = tb_inmenit52;
            input_menit[52] = tb_inmenit53;
            input_menit[53] = tb_inmenit54;
            input_menit[54] = tb_inmenit55;
            input_menit[55] = tb_inmenit56;
            input_menit[56] = tb_inmenit57;
            input_menit[57] = tb_inmenit58;
            input_menit[58] = tb_inmenit59;
            input_menit[59] = tb_inmenit60;
        }

        private void setDetik(TextBox[] input_detik)
        {
            input_detik[0] = tb_indetik1;
            input_detik[1] = tb_indetik2;
            input_detik[2] = tb_indetik3;
            input_detik[3] = tb_indetik4;
            input_detik[4] = tb_indetik5;
            input_detik[5] = tb_indetik6;
            input_detik[6] = tb_indetik7;
            input_detik[7] = tb_indetik8;
            input_detik[8] = tb_indetik9;
            input_detik[9] = tb_indetik10;
            input_detik[10] = tb_indetik11;
            input_detik[11] = tb_indetik12;
            input_detik[12] = tb_indetik13;
            input_detik[13] = tb_indetik14;
            input_detik[14] = tb_indetik15;
            input_detik[15] = tb_indetik16;
            input_detik[16] = tb_indetik17;
            input_detik[17] = tb_indetik18;
            input_detik[18] = tb_indetik19;
            input_detik[19] = tb_indetik20;
            input_detik[20] = tb_indetik21;
            input_detik[21] = tb_indetik22;
            input_detik[22] = tb_indetik23;
            input_detik[23] = tb_indetik24;
            input_detik[24] = tb_indetik25;
            input_detik[25] = tb_indetik26;
            input_detik[26] = tb_indetik27;
            input_detik[27] = tb_indetik28;
            input_detik[28] = tb_indetik29;
            input_detik[29] = tb_indetik30;
            input_detik[30] = tb_indetik31;
            input_detik[31] = tb_indetik32;
            input_detik[32] = tb_indetik33;
            input_detik[33] = tb_indetik34;
            input_detik[34] = tb_indetik35;
            input_detik[35] = tb_indetik36;
            input_detik[36] = tb_indetik37;
            input_detik[37] = tb_indetik38;
            input_detik[38] = tb_indetik39;
            input_detik[39] = tb_indetik40;
            input_detik[40] = tb_indetik41;
            input_detik[41] = tb_indetik42;
            input_detik[42] = tb_indetik43;
            input_detik[43] = tb_indetik44;
            input_detik[44] = tb_indetik45;
            input_detik[45] = tb_indetik46;
            input_detik[46] = tb_indetik47;
            input_detik[47] = tb_indetik48;
            input_detik[48] = tb_indetik49;
            input_detik[49] = tb_indetik50;
            input_detik[50] = tb_indetik51;
            input_detik[51] = tb_indetik52;
            input_detik[52] = tb_indetik53;
            input_detik[53] = tb_indetik54;
            input_detik[54] = tb_indetik55;
            input_detik[55] = tb_indetik56;
            input_detik[56] = tb_indetik57;
            input_detik[57] = tb_indetik58;
            input_detik[58] = tb_indetik59;
            input_detik[59] = tb_indetik60;
        }

        private void setDurasi(TextBox[] input_durasi)
        {
            input_durasi[0] = tb_indur1;
            input_durasi[1] = tb_indur2;
            input_durasi[2] = tb_indur3;
            input_durasi[3] = tb_indur4;
            input_durasi[4] = tb_indur5;
            input_durasi[5] = tb_indur6;
            input_durasi[6] = tb_indur7;
            input_durasi[7] = tb_indur8;
            input_durasi[8] = tb_indur9;
            input_durasi[9] = tb_indur10;
            input_durasi[10] = tb_indur11;
            input_durasi[11] = tb_indur12;
            input_durasi[12] = tb_indur13;
            input_durasi[13] = tb_indur14;
            input_durasi[14] = tb_indur15;
            input_durasi[15] = tb_indur16;
            input_durasi[16] = tb_indur17;
            input_durasi[17] = tb_indur18;
            input_durasi[18] = tb_indur19;
            input_durasi[19] = tb_indur20;
            input_durasi[20] = tb_indur21;
            input_durasi[21] = tb_indur22;
            input_durasi[22] = tb_indur23;
            input_durasi[23] = tb_indur24;
            input_durasi[24] = tb_indur25;
            input_durasi[25] = tb_indur26;
            input_durasi[26] = tb_indur27;
            input_durasi[27] = tb_indur28;
            input_durasi[28] = tb_indur29;
            input_durasi[29] = tb_indur30;
            input_durasi[30] = tb_indur31;
            input_durasi[31] = tb_indur32;
            input_durasi[32] = tb_indur33;
            input_durasi[33] = tb_indur34;
            input_durasi[34] = tb_indur35;
            input_durasi[35] = tb_indur36;
            input_durasi[36] = tb_indur37;
            input_durasi[37] = tb_indur38;
            input_durasi[38] = tb_indur39;
            input_durasi[39] = tb_indur40;
            input_durasi[40] = tb_indur41;
            input_durasi[41] = tb_indur42;
            input_durasi[42] = tb_indur43;
            input_durasi[43] = tb_indur44;
            input_durasi[44] = tb_indur45;
            input_durasi[45] = tb_indur46;
            input_durasi[46] = tb_indur47;
            input_durasi[47] = tb_indur48;
            input_durasi[48] = tb_indur49;
            input_durasi[49] = tb_indur50;
            input_durasi[50] = tb_indur51;
            input_durasi[51] = tb_indur52;
            input_durasi[52] = tb_indur53;
            input_durasi[53] = tb_indur54;
            input_durasi[54] = tb_indur55;
            input_durasi[55] = tb_indur56;
            input_durasi[56] = tb_indur57;
            input_durasi[57] = tb_indur58;
            input_durasi[58] = tb_indur59;
            input_durasi[59] = tb_indur60;
        }

        private void inIp(TextBox[] input_ip)
        {
            input_ip[0] = tb_ip1;
            input_ip[1] = tb_ip2;
            input_ip[2] = tb_ip3;
            input_ip[3] = tb_ip4;
            input_ip[4] = tb_netmask1;
            input_ip[5] = tb_netmask2;
            input_ip[6] = tb_netmask3;
            input_ip[7] = tb_netmask4;
            input_ip[8] = tb_gw1;
            input_ip[9] = tb_gw2;
            input_ip[10] = tb_gw3;
            input_ip[11] = tb_gw4;
        }

        private void setBell()
        {
            setSenin(input_senin);
            setSelasa(input_selasa);
            setRabu(input_rabu);
            setKamis(input_kamis);
            setJumat(input_jumat);
            setSabtu(input_sabtu);
            setMinggu(input_minggu);

            setJam(input_jam);
            setMenit(input_menit);
            setDetik(input_detik);
            setDurasi(input_durasi);

            string rt = string.Empty;
            var j = input_jam.Length;
            for (int i=0;i<j;i++)
            {
                
                var nJam = input_jam[i];
                var nSenin = input_senin[i];
                var nSelasa = input_selasa[i];
                var nRabu = input_rabu[i];
                var nKamis = input_kamis[i];
                var nJumat = input_jumat[i];
                var nSabtu = input_sabtu[i];
                var nMinggu = input_minggu[i];

                var tk = String.IsNullOrEmpty(nJam.Text);

                List<string> HariList = new List<string>();

                if (nMinggu.Checked) { HariList.Add("1"); } else { HariList.Add("0"); }
                if (nSenin.Checked){ HariList.Add("2"); } else { HariList.Add("0"); }
                if (nSelasa.Checked) { HariList.Add("3"); } else { HariList.Add("0"); }
                if (nRabu.Checked) { HariList.Add("4"); } else { HariList.Add("0"); }
                if (nKamis.Checked) { HariList.Add("5"); } else { HariList.Add("0"); }
                if (nJumat.Checked) { HariList.Add("6"); } else { HariList.Add("0"); }
                if (nSabtu.Checked) { HariList.Add("7"); } else { HariList.Add("0"); }
                dataHari = String.Join(",", HariList.ToArray()); ;

                if (!tk)
                {
                    try
                    {
                        var injam = input_jam[i].Text;
                        var inmenit = input_menit[i].Text;
                        var indetik = input_detik[i].Text;
                        var indurasi = input_durasi[i].Text;

                        addBell = injam + "," + inmenit + "," + indetik + "," + indurasi;
                        simpan = new string[] { addBell +","+ dataHari};
                        
                        File.AppendAllLines(dataBell,simpan);

                        //Console.WriteLine(addBell + dataHari);
                        serialPort1.WriteLine(addBell + "," + dataHari);
                    }
                    catch (Exception ex) { alert.Show("Failed to add bell.", alert.AlertType.error); Console.WriteLine(ex.Message.ToString()); }
                }

            }

        }

        private void setIp()
        {
            try
            {
                string ipnya = tb_ip1.Text + "," + tb_ip2.Text + "," + tb_ip3.Text + "," + tb_ip4.Text;
                string netmasknya = tb_netmask1.Text + "," + tb_netmask2.Text + "," + tb_netmask3.Text + "," + tb_netmask4.Text;
                string gateway = tb_gw1.Text + "," + tb_gw2.Text + "," + tb_gw3.Text + "," + tb_gw4.Text;
                string sipnya = "ip/" + tb_ip1.Text + "," + tb_ip2.Text + "," + tb_ip3.Text + "," + tb_ip4.Text;
                string snetmasknya = "/" + tb_netmask1.Text + "," + tb_netmask2.Text + "," + tb_netmask3.Text + "," + tb_netmask4.Text;
                string sgateway = "/" + tb_gw1.Text + "," + tb_gw2.Text + "," + tb_gw3.Text + "," + tb_gw4.Text;
                //Console.WriteLine(sipnya + snetmasknya + sgateway);
                var sip = ipnya + "," + netmasknya + "," + gateway;
                saveip = new string[] { ipnya + "," + netmasknya + "," + gateway };
                File.AppendAllText(ipConfig, sip);
                serialPort1.WriteLine(ipnya + netmasknya + gateway);
                alert.Show("IP has been saved.", alert.AlertType.success);
            }
            catch (Exception ex) { alert.Show("Failed to setup IP.", alert.AlertType.error); Console.WriteLine(ex.Message.ToString()); }
        }

        private void getBell()
        {
            setJam(input_jam);
            setMenit(input_menit);
            setDetik(input_detik);
            setDurasi(input_durasi);
            setSenin(input_senin);
            setSelasa(input_selasa);
            setRabu(input_rabu);
            setKamis(input_kamis);
            setJumat(input_jumat);
            setSabtu(input_sabtu);
            setMinggu(input_minggu);

            var dbell = File.ReadAllText(dataBell);
            string[] rb = dbell.Split("\r\n".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < rb.Length; i++)
            {
                var ni = rb[i];
                int getJam = ni.IndexOf(',');
                int getMenit = ni.IndexOf(',', getJam + 1);
                int getDetik = ni.IndexOf(',', getMenit + 1);
                int getDurasi = ni.IndexOf(',', getDetik + 1);
                int getMinggu = ni.IndexOf(',', getDurasi + 1);
                int getSenin = ni.IndexOf(',', getMinggu + 1);
                int getSelasa = ni.IndexOf(',', getSenin + 1);
                int getRabu = ni.IndexOf(',', getSelasa + 1);
                int getKamis = ni.IndexOf(',', getRabu + 1);
                int getJumat= ni.IndexOf(',', getKamis + 1);
                int getSabtu = ni.IndexOf(',', getJumat+ 1);

                string gj = ni.Substring(0,getJam);
                string gm = ni.Substring(getJam + 1, getJam);
                string gd = ni.Substring(getMenit + 1, getJam);
                string gdur = ni.Substring(getDetik + 1, getJam);
                string gming = ni.Substring(getDurasi + 1, getJam);
                string gsen = ni.Substring(getMinggu + 1, getJam);
                string gsel = ni.Substring(getSenin + 1, getJam);
                string grab = ni.Substring(getSelasa + 1, getJam);
                string gkam = ni.Substring(getRabu + 1, getJam);
                string gjum = ni.Substring(getKamis + 1, getJam);
                string gsab = ni.Substring(getJumat + 1);

                input_jam[i].Text = gj;
                input_menit[i].Text = gm;
                input_detik[i].Text = gd;
                input_durasi[i].Text = gdur;
                if (gming == "1,") { input_minggu[i].Checked = true; } else { input_minggu[i].Checked = false; }
                if (gsen == "2,") { input_senin[i].Checked = true; } else { input_senin[i].Checked = false; }
                if (gsel == "3,") { input_selasa[i].Checked = true; } else { input_selasa[i].Checked = false; }
                if (grab == "4,") { input_rabu[i].Checked = true; } else { input_rabu[i].Checked = false; }
                if (gkam == "5,") { input_kamis[i].Checked = true; } else { input_kamis[i].Checked = false; }
                if (gjum == "6,") { input_jumat[i].Checked = true; } else { input_jumat[i].Checked = false; }
                if (gsab == "7,") { input_sabtu[i].Checked = true; } else { input_sabtu[i].Checked = false; }

                //string bb = "bell" + i + ": ";
                //Console.WriteLine(gj+"\n"+gm + "\n" +gd + "\n" +gdur + "\n" +gming + "\n" +gsen + "\n" +gsel + "\n" +grab + "\n" +gkam + "\n" +gjum + "\n" +gsab);
            }
        }

        private void bersihkan()
        {
            setJam(input_jam);
            setMenit(input_menit);
            setDetik(input_detik);
            setDurasi(input_durasi);
            setSenin(input_senin);
            setSelasa(input_selasa);
            setRabu(input_rabu);
            setKamis(input_kamis);
            setJumat(input_jumat);
            setSabtu(input_sabtu);
            setMinggu(input_minggu);
            foreach (TextBox a in input_jam) { a.Text = ""; }
            foreach (TextBox a in input_menit) { a.Text = ""; }
            foreach (TextBox a in input_detik) { a.Text = ""; }
            foreach (TextBox a in input_durasi) { a.Text = ""; }
            foreach (CheckBox a in input_senin) { a.Checked = false; }
            foreach (CheckBox a in input_selasa) { a.Checked = false; }
            foreach (CheckBox a in input_rabu) { a.Checked = false; }
            foreach (CheckBox a in input_kamis) { a.Checked = false; }
            foreach (CheckBox a in input_jumat) { a.Checked = false; }
            foreach (CheckBox a in input_sabtu) { a.Checked = false; }
            foreach (CheckBox a in input_minggu) { a.Checked = false; }
        }

        private void getIp()
        {
            inIp(input_ip);
            var dip = File.ReadAllText(ipConfig);
            string[] ri = dip.Split(",".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            for (int i=0;i<ri.Length;i++)
            {
                input_ip[i].Text = ri[i];
            }

        }

        private void btn_konek_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.PortName = pilih_comport.SelectedItem.ToString();
                serialPort1.BaudRate = Convert.ToInt32(pilih_baudrate.SelectedItem.ToString());
                serialPort1.Open();
                alert.Show("Connected.", alert.AlertType.success);
            }
            catch (Exception ex)
            {
                alert.Show("Error... Please try again!", alert.AlertType.error);
                Console.WriteLine(ex.Message.ToString());
            }
            panel_konfig.Visible = true;

        }

        private void pilih_comport_MouseClick(object sender, MouseEventArgs e)
        {
            pilih_comport.Items.Clear();
            string[] ports = SerialPort.GetPortNames();
            foreach (string port in ports) { pilih_comport.Items.Add(port); }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == true)
            {
                btn_diskonek.Visible = true;
                panel_konfig.Visible = true;
                //panel_konek.Visible = false;
                

            }
            else
            {
                btn_diskonek.Visible = false;
                panel_konfig.Visible = false;
                panel_ipconfig.Visible = false;

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btn_diskonek.Visible = false;
            panel_konfig.Visible = false;
            panel_ipconfig.Visible = false;
            tabPage1.AutoScroll = true;
            tabPage2.AutoScroll = true;
            tabPage3.AutoScroll = true;
            tabPage4.AutoScroll = true;
            tabPage5.AutoScroll = true;
            tabPage6.AutoScroll = true;
            if (File.Exists(dataBell) && File.Exists(ipConfig)) {getBell(); getIp();
            }
            else { File.WriteAllText(dataBell, String.Empty); File.WriteAllText(ipConfig, String.Empty); }

        }

        private void btn_diskonek_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
            alert.Show("Disconnected.", alert.AlertType.success);
        }

        private void btn_ipconfig_Click(object sender, EventArgs e)
        {
            var cek = panel_ipconfig.Visible;
            if (cek == true) { panel_ipconfig.Visible = false; }
            else { panel_ipconfig.Visible = true; }
        }

        private void btn_saveip_Click(object sender, EventArgs e)
        {
            File.WriteAllText(ipConfig, String.Empty);
            setIp();
            getIp();
        }

        private void btn_help_Click(object sender, EventArgs e)
        {
            new help().Show();
        }

        private void pilih_comport_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A) { new tentang().Show(); }
        }

        private void btn_modif_Click(object sender, EventArgs e)
        {
            try {
                serialPort1.Write("m");
                Thread.Sleep(2000);
                File.WriteAllText(dataBell, String.Empty);
                setBell();
                alert.Show("Data saved!", alert.AlertType.success);
                bersihkan();
                getBell();
            }
            catch (Exception ex) { alert.Show("Failed!", alert.AlertType.error); Console.WriteLine(ex.Message.ToString()); }
        }

    }
}
