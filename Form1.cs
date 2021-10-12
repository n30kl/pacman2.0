using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Timers;
using System.Diagnostics;

namespace PacManGame
{
    public partial class Form1 : Form
    {

        bool goup, godown, goleft, goright, isGameOver;

        int score, playerSpeed, redGhostSpeedX, redGhostSpeedY, yellowGhostSpeedX, yellowGhostSpeedY, pinkGhostSpeedX, pinkGhostSpeedY;
        int i { get; set; } = 0;
        public Form1()
        {
            InitializeComponent();

            resetGame();

        }

        private void keyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
                goup = true;
            if (e.KeyCode == Keys.Down)
                godown = true;
            if (e.KeyCode == Keys.Left)
                goleft = true;
            if (e.KeyCode == Keys.Right)
                goright = true;

        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
                goup = false;
            if (e.KeyCode == Keys.Down)
                godown = false;
            if (e.KeyCode == Keys.Left)
                goleft = false;
            if (e.KeyCode == Keys.Right)
                goright = false;
            if (e.KeyCode == Keys.Enter && isGameOver == true)
                resetGame();
            if (e.KeyCode == Keys.Space)
            {
                if (i == 0)
                    i = 1;
                else
                if (i == 1)
                    i = 2;
                else
                if (i == 2)
                    i = 0;
            }

        }

        private void mainGameTimer(object sender, EventArgs e)
        {
            label1.Text = "Счёт: " + score;

            #region New nodes
            var start = new Node("");
            var endY = new Node("");
            var endP = new Node("");
            var endR = new Node("");
            var n112 = new Node(Convert.ToString(Dots()[0].Top + "," + Dots()[0].Left));
            var n116 = new Node(Convert.ToString(Dots()[1].Top + "," + Dots()[1].Left));
            var n117 = new Node(Convert.ToString(Dots()[2].Top + "," + Dots()[2].Left));
            var n118 = new Node(Convert.ToString(Dots()[3].Top + "," + Dots()[3].Left));
            var n119 = new Node(Convert.ToString(Dots()[4].Top + "," + Dots()[4].Left));
            var n120 = new Node(Convert.ToString(Dots()[5].Top + "," + Dots()[5].Left));
            var n121 = new Node(Convert.ToString(Dots()[6].Top + "," + Dots()[6].Left));
            var n122 = new Node(Convert.ToString(Dots()[7].Top + "," + Dots()[7].Left));
            var n123 = new Node(Convert.ToString(Dots()[8].Top + "," + Dots()[8].Left));
            var n124 = new Node(Convert.ToString(Dots()[9].Top + "," + Dots()[9].Left));
            var n125 = new Node(Convert.ToString(Dots()[10].Top + "," + Dots()[10].Left));
            var n126 = new Node(Convert.ToString(Dots()[11].Top + "," + Dots()[11].Left));
            var n127 = new Node(Convert.ToString(Dots()[12].Top + "," + Dots()[12].Left));
            var n128 = new Node(Convert.ToString(Dots()[13].Top + "," + Dots()[13].Left));
            var n129 = new Node(Convert.ToString(Dots()[14].Top + "," + Dots()[14].Left));
            var n130 = new Node(Convert.ToString(Dots()[15].Top + "," + Dots()[15].Left));
            var n131 = new Node(Convert.ToString(Dots()[16].Top + "," + Dots()[16].Left));
            var n132 = new Node(Convert.ToString(Dots()[17].Top + "," + Dots()[17].Left));
            var n133 = new Node(Convert.ToString(Dots()[18].Top + "," + Dots()[18].Left));
            var n134 = new Node(Convert.ToString(Dots()[19].Top + "," + Dots()[19].Left));
            var n135 = new Node(Convert.ToString(Dots()[20].Top + "," + Dots()[20].Left));
            var n136 = new Node(Convert.ToString(Dots()[21].Top + "," + Dots()[21].Left));
            var n137 = new Node(Convert.ToString(Dots()[22].Top + "," + Dots()[22].Left));
            var n138 = new Node(Convert.ToString(Dots()[23].Top + "," + Dots()[23].Left));
            var n139 = new Node(Convert.ToString(Dots()[24].Top + "," + Dots()[24].Left));
            var n140 = new Node(Convert.ToString(Dots()[25].Top + "," + Dots()[25].Left));
            var n141 = new Node(Convert.ToString(Dots()[26].Top + "," + Dots()[26].Left));
            var n142 = new Node(Convert.ToString(Dots()[27].Top + "," + Dots()[27].Left));
            var n143 = new Node(Convert.ToString(Dots()[28].Top + "," + Dots()[28].Left));
            var n144 = new Node(Convert.ToString(Dots()[29].Top + "," + Dots()[29].Left));
            var n145 = new Node(Convert.ToString(Dots()[30].Top + "," + Dots()[30].Left));
            var n146 = new Node(Convert.ToString(Dots()[31].Top + "," + Dots()[31].Left));
            var n147 = new Node(Convert.ToString(Dots()[32].Top + "," + Dots()[32].Left));
            var n148 = new Node(Convert.ToString(Dots()[33].Top + "," + Dots()[33].Left));
            var n149 = new Node(Convert.ToString(Dots()[34].Top + "," + Dots()[34].Left));
            var n150 = new Node(Convert.ToString(Dots()[35].Top + "," + Dots()[35].Left));
            var n151 = new Node(Convert.ToString(Dots()[36].Top + "," + Dots()[36].Left));
            var n152 = new Node(Convert.ToString(Dots()[37].Top + "," + Dots()[37].Left));
            var n153 = new Node(Convert.ToString(Dots()[38].Top + "," + Dots()[38].Left));
            var n154 = new Node(Convert.ToString(Dots()[39].Top + "," + Dots()[39].Left));
            var n155 = new Node(Convert.ToString(Dots()[40].Top + "," + Dots()[40].Left));
            var n156 = new Node(Convert.ToString(Dots()[41].Top + "," + Dots()[41].Left));
            var n157 = new Node(Convert.ToString(Dots()[42].Top + "," + Dots()[42].Left));
            var n158 = new Node(Convert.ToString(Dots()[43].Top + "," + Dots()[43].Left));
            var n159 = new Node(Convert.ToString(Dots()[44].Top + "," + Dots()[44].Left));
            var n160 = new Node(Convert.ToString(Dots()[45].Top + "," + Dots()[45].Left));
            var n161 = new Node(Convert.ToString(Dots()[46].Top + "," + Dots()[46].Left));
            var n162 = new Node(Convert.ToString(Dots()[47].Top + "," + Dots()[47].Left));
            var n163 = new Node(Convert.ToString(Dots()[48].Top + "," + Dots()[48].Left));
            var n164 = new Node(Convert.ToString(Dots()[49].Top + "," + Dots()[49].Left));
            var n165 = new Node(Convert.ToString(Dots()[50].Top + "," + Dots()[50].Left));
            var n166 = new Node(Convert.ToString(Dots()[51].Top + "," + Dots()[51].Left));
            var n167 = new Node(Convert.ToString(Dots()[52].Top + "," + Dots()[52].Left));
            var n168 = new Node(Convert.ToString(Dots()[53].Top + "," + Dots()[53].Left));
            var n169 = new Node(Convert.ToString(Dots()[54].Top + "," + Dots()[54].Left));
            var n170 = new Node(Convert.ToString(Dots()[55].Top + "," + Dots()[55].Left));
            var n171 = new Node(Convert.ToString(Dots()[56].Top + "," + Dots()[56].Left));
            var n172 = new Node(Convert.ToString(Dots()[57].Top + "," + Dots()[57].Left));
            var n173 = new Node(Convert.ToString(Dots()[58].Top + "," + Dots()[58].Left));
            var n174 = new Node(Convert.ToString(Dots()[59].Top + "," + Dots()[59].Left));
            var n175 = new Node(Convert.ToString(Dots()[60].Top + "," + Dots()[60].Left));
            var n176 = new Node(Convert.ToString(Dots()[61].Top + "," + Dots()[61].Left));
            var n177 = new Node(Convert.ToString(Dots()[62].Top + "," + Dots()[62].Left));
            var n178 = new Node(Convert.ToString(Dots()[63].Top + "," + Dots()[63].Left));
            var n179 = new Node(Convert.ToString(Dots()[64].Top + "," + Dots()[64].Left));
            var n180 = new Node(Convert.ToString(Dots()[65].Top + "," + Dots()[65].Left));
            var n181 = new Node(Convert.ToString(Dots()[66].Top + "," + Dots()[66].Left));
            var n182 = new Node(Convert.ToString(Dots()[67].Top + "," + Dots()[67].Left));
            var n183 = new Node(Convert.ToString(Dots()[68].Top + "," + Dots()[68].Left));
            var n184 = new Node(Convert.ToString(Dots()[69].Top + "," + Dots()[69].Left));
            var n185 = new Node(Convert.ToString(Dots()[70].Top + "," + Dots()[70].Left));
            var n186 = new Node(Convert.ToString(Dots()[71].Top + "," + Dots()[71].Left));
            var n187 = new Node(Convert.ToString(Dots()[72].Top + "," + Dots()[72].Left));
            var n188 = new Node(Convert.ToString(Dots()[73].Top + "," + Dots()[73].Left));
            var n189 = new Node(Convert.ToString(Dots()[74].Top + "," + Dots()[74].Left));
            var n190 = new Node(Convert.ToString(Dots()[75].Top + "," + Dots()[75].Left));
            var n191 = new Node(Convert.ToString(Dots()[76].Top + "," + Dots()[76].Left));
            var n192 = new Node(Convert.ToString(Dots()[77].Top + "," + Dots()[77].Left));
            var n193 = new Node(Convert.ToString(Dots()[78].Top + "," + Dots()[78].Left));
            var n194 = new Node(Convert.ToString(Dots()[79].Top + "," + Dots()[79].Left));
            var n195 = new Node(Convert.ToString(Dots()[80].Top + "," + Dots()[80].Left));
            var n196 = new Node(Convert.ToString(Dots()[81].Top + "," + Dots()[81].Left));
            var n197 = new Node(Convert.ToString(Dots()[82].Top + "," + Dots()[82].Left));
            var n198 = new Node(Convert.ToString(Dots()[83].Top + "," + Dots()[83].Left));
            var n199 = new Node(Convert.ToString(Dots()[84].Top + "," + Dots()[84].Left));
            var n200 = new Node(Convert.ToString(Dots()[85].Top + "," + Dots()[85].Left));
            var n201 = new Node(Convert.ToString(Dots()[86].Top + "," + Dots()[86].Left));
            var n202 = new Node(Convert.ToString(Dots()[87].Top + "," + Dots()[87].Left));
            var n203 = new Node(Convert.ToString(Dots()[88].Top + "," + Dots()[88].Left));
            var n204 = new Node(Convert.ToString(Dots()[89].Top + "," + Dots()[89].Left));
            var n205 = new Node(Convert.ToString(Dots()[90].Top + "," + Dots()[90].Left));
            var n206 = new Node(Convert.ToString(Dots()[91].Top + "," + Dots()[91].Left));
            var n207 = new Node(Convert.ToString(Dots()[92].Top + "," + Dots()[92].Left));
            var n208 = new Node(Convert.ToString(Dots()[93].Top + "," + Dots()[93].Left));
            var n209 = new Node(Convert.ToString(Dots()[94].Top + "," + Dots()[94].Left));
            var n210 = new Node(Convert.ToString(Dots()[95].Top + "," + Dots()[95].Left));
            var n211 = new Node(Convert.ToString(Dots()[96].Top + "," + Dots()[96].Left));
            var n212 = new Node(Convert.ToString(Dots()[97].Top + "," + Dots()[97].Left));
            var n213 = new Node(Convert.ToString(Dots()[98].Top + "," + Dots()[98].Left));
            var n214 = new Node(Convert.ToString(Dots()[99].Top + "," + Dots()[99].Left));
            var n215 = new Node(Convert.ToString(Dots()[100].Top + "," + Dots()[100].Left));
            var n216 = new Node(Convert.ToString(Dots()[101].Top + "," + Dots()[101].Left));
            var n217 = new Node(Convert.ToString(Dots()[102].Top + "," + Dots()[102].Left));
            var n218 = new Node(Convert.ToString(Dots()[103].Top + "," + Dots()[103].Left));
            var n219 = new Node(Convert.ToString(Dots()[104].Top + "," + Dots()[104].Left));
            var n220 = new Node(Convert.ToString(Dots()[105].Top + "," + Dots()[105].Left));
            var n221 = new Node(Convert.ToString(Dots()[106].Top + "," + Dots()[106].Left));
            var n222 = new Node(Convert.ToString(Dots()[107].Top + "," + Dots()[107].Left));
            var n223 = new Node(Convert.ToString(Dots()[108].Top + "," + Dots()[108].Left));
            var n224 = new Node(Convert.ToString(Dots()[109].Top + "," + Dots()[109].Left));
            var n225 = new Node(Convert.ToString(Dots()[110].Top + "," + Dots()[110].Left));
            var n226 = new Node(Convert.ToString(Dots()[111].Top + "," + Dots()[111].Left));
            var n227 = new Node(Convert.ToString(Dots()[112].Top + "," + Dots()[112].Left));
            var n228 = new Node(Convert.ToString(Dots()[113].Top + "," + Dots()[113].Left));
            var n229 = new Node(Convert.ToString(Dots()[114].Top + "," + Dots()[114].Left));
            var n230 = new Node(Convert.ToString(Dots()[115].Top + "," + Dots()[115].Left));
            var n231 = new Node(Convert.ToString(Dots()[116].Top + "," + Dots()[116].Left));
            var n232 = new Node(Convert.ToString(Dots()[117].Top + "," + Dots()[117].Left));
            var n233 = new Node(Convert.ToString(Dots()[118].Top + "," + Dots()[118].Left));
            var n234 = new Node(Convert.ToString(Dots()[119].Top + "," + Dots()[119].Left));
            var n235 = new Node(Convert.ToString(Dots()[120].Top + "," + Dots()[120].Left));
            var n236 = new Node(Convert.ToString(Dots()[121].Top + "," + Dots()[121].Left));
            var n237 = new Node(Convert.ToString(Dots()[122].Top + "," + Dots()[122].Left));
            var n238 = new Node(Convert.ToString(Dots()[123].Top + "," + Dots()[123].Left));
            var n239 = new Node(Convert.ToString(Dots()[124].Top + "," + Dots()[124].Left));
            var n240 = new Node(Convert.ToString(Dots()[125].Top + "," + Dots()[125].Left));
            var n241 = new Node(Convert.ToString(Dots()[126].Top + "," + Dots()[126].Left));
            var n242 = new Node(Convert.ToString(Dots()[127].Top + "," + Dots()[127].Left));
            var n243 = new Node(Convert.ToString(Dots()[128].Top + "," + Dots()[128].Left));
            var n244 = new Node(Convert.ToString(Dots()[129].Top + "," + Dots()[129].Left));
            var n245 = new Node(Convert.ToString(Dots()[130].Top + "," + Dots()[130].Left));
            var n246 = new Node(Convert.ToString(Dots()[131].Top + "," + Dots()[131].Left));
            var n247 = new Node(Convert.ToString(Dots()[132].Top + "," + Dots()[132].Left));
            var n248 = new Node(Convert.ToString(Dots()[133].Top + "," + Dots()[133].Left));
            var n249 = new Node(Convert.ToString(Dots()[134].Top + "," + Dots()[134].Left));
            var n250 = new Node(Convert.ToString(Dots()[135].Top + "," + Dots()[135].Left));
            var n251 = new Node(Convert.ToString(Dots()[136].Top + "," + Dots()[136].Left));
            var n252 = new Node(Convert.ToString(Dots()[137].Top + "," + Dots()[137].Left));
            var n253 = new Node(Convert.ToString(Dots()[138].Top + "," + Dots()[138].Left));
            var n254 = new Node(Convert.ToString(Dots()[139].Top + "," + Dots()[139].Left));
            var n255 = new Node(Convert.ToString(Dots()[140].Top + "," + Dots()[140].Left));
            var n256 = new Node(Convert.ToString(Dots()[141].Top + "," + Dots()[141].Left));
            var n257 = new Node(Convert.ToString(Dots()[142].Top + "," + Dots()[142].Left));


            n112.AddChildren(n129).AddChildren(n142).AddChildren(n155).AddChildren(n168).AddChildren(n181).AddChildren(n194).AddChildren(n207).AddChildren(n220).AddChildren(n246).AddChildren(n233);
            n116.AddChildren(n128).AddChildren(n141).AddChildren(n154).AddChildren(n167).AddChildren(n180).AddChildren(n193).AddChildren(n206).AddChildren(n219).AddChildren(n245).AddChildren(n232);
            n117.AddChildren(n130).AddChildren(n143).AddChildren(n156).AddChildren(n169).AddChildren(n182).AddChildren(n195).AddChildren(n208).AddChildren(n221).AddChildren(n247).AddChildren(n234);
            n118.AddChildren(n131).AddChildren(n144).AddChildren(n157).AddChildren(n170).AddChildren(n183).AddChildren(n196).AddChildren(n209).AddChildren(n222).AddChildren(n248).AddChildren(n235);
            n119.AddChildren(n132).AddChildren(n145).AddChildren(n158).AddChildren(n171).AddChildren(n184).AddChildren(n197).AddChildren(n210).AddChildren(n223).AddChildren(n249).AddChildren(n236);
            n120.AddChildren(n133).AddChildren(n146).AddChildren(n159).AddChildren(n172).AddChildren(n185).AddChildren(n198).AddChildren(n211).AddChildren(n224).AddChildren(n250).AddChildren(n237);
            n121.AddChildren(n134).AddChildren(n147).AddChildren(n160).AddChildren(n173).AddChildren(n186).AddChildren(n199).AddChildren(n212).AddChildren(n225).AddChildren(n251).AddChildren(n238);
            n122.AddChildren(n135).AddChildren(n148).AddChildren(n161).AddChildren(n174).AddChildren(n187).AddChildren(n200).AddChildren(n213).AddChildren(n226).AddChildren(n252).AddChildren(n239);
            n123.AddChildren(n136).AddChildren(n149).AddChildren(n162).AddChildren(n175).AddChildren(n188).AddChildren(n201).AddChildren(n214).AddChildren(n227).AddChildren(n253).AddChildren(n240);
            n124.AddChildren(n137).AddChildren(n150).AddChildren(n163).AddChildren(n176).AddChildren(n189).AddChildren(n202).AddChildren(n215).AddChildren(n228).AddChildren(n254).AddChildren(n241);
            n125.AddChildren(n138).AddChildren(n151).AddChildren(n164).AddChildren(n177).AddChildren(n190).AddChildren(n203).AddChildren(n216).AddChildren(n229).AddChildren(n255).AddChildren(n242);
            n126.AddChildren(n139).AddChildren(n152).AddChildren(n165).AddChildren(n178).AddChildren(n191).AddChildren(n204).AddChildren(n217).AddChildren(n230).AddChildren(n256).AddChildren(n243);
            n127.AddChildren(n140).AddChildren(n153).AddChildren(n166).AddChildren(n179).AddChildren(n192).AddChildren(n205).AddChildren(n218).AddChildren(n231).AddChildren(n257).AddChildren(n244);
            n112.AddChildren(n116).AddChildren(n117).AddChildren(n118).AddChildren(n119).AddChildren(n120).AddChildren(n121).AddChildren(n122).AddChildren(n123).AddChildren(n124).AddChildren(n125).AddChildren(n126).AddChildren(n127);
            n129.AddChildren(n128).AddChildren(n130).AddChildren(n131).AddChildren(n132).AddChildren(n133).AddChildren(n134).AddChildren(n135).AddChildren(n136).AddChildren(n137).AddChildren(n138).AddChildren(n139).AddChildren(n140);
            n142.AddChildren(n141).AddChildren(n143).AddChildren(n144).AddChildren(n145).AddChildren(n146).AddChildren(n147).AddChildren(n148).AddChildren(n149).AddChildren(n150).AddChildren(n151).AddChildren(n152).AddChildren(n153);
            n155.AddChildren(n154).AddChildren(n156).AddChildren(n157).AddChildren(n158).AddChildren(n159).AddChildren(n160).AddChildren(n161).AddChildren(n162).AddChildren(n163).AddChildren(n164).AddChildren(n165).AddChildren(n166);
            n168.AddChildren(n167).AddChildren(n169).AddChildren(n170).AddChildren(n171).AddChildren(n172).AddChildren(n173).AddChildren(n174).AddChildren(n175).AddChildren(n176).AddChildren(n177).AddChildren(n178).AddChildren(n179);
            n181.AddChildren(n180).AddChildren(n182).AddChildren(n183).AddChildren(n184).AddChildren(n185).AddChildren(n186).AddChildren(n187).AddChildren(n188).AddChildren(n189).AddChildren(n190).AddChildren(n191).AddChildren(n192);
            n194.AddChildren(n193).AddChildren(n195).AddChildren(n196).AddChildren(n197).AddChildren(n198).AddChildren(n199).AddChildren(n200).AddChildren(n201).AddChildren(n202).AddChildren(n203).AddChildren(n204).AddChildren(n205);
            n207.AddChildren(n206).AddChildren(n208).AddChildren(n209).AddChildren(n210).AddChildren(n211).AddChildren(n212).AddChildren(n213).AddChildren(n214).AddChildren(n215).AddChildren(n216).AddChildren(n117).AddChildren(n218);
            n220.AddChildren(n219).AddChildren(n221).AddChildren(n222).AddChildren(n223).AddChildren(n224).AddChildren(n225).AddChildren(n226).AddChildren(n227).AddChildren(n228).AddChildren(n229).AddChildren(n230).AddChildren(n231);
            n146.AddChildren(n245).AddChildren(n247).AddChildren(n248).AddChildren(n249).AddChildren(n250).AddChildren(n251).AddChildren(n252).AddChildren(n253).AddChildren(n254).AddChildren(n255).AddChildren(n256).AddChildren(n257);
            n233.AddChildren(n232).AddChildren(n234).AddChildren(n235).AddChildren(n236).AddChildren(n237).AddChildren(n238).AddChildren(n239).AddChildren(n240).AddChildren(n241).AddChildren(n242).AddChildren(n243).AddChildren(n244);


            #endregion


            #region list of nodes
            List<Node> Nodes = new List<Node>();
            Nodes.Add(n112);
            Nodes.Add(n116);
            Nodes.Add(n117);
            Nodes.Add(n118);
            Nodes.Add(n119);
            Nodes.Add(n120);
            Nodes.Add(n121);
            Nodes.Add(n122);
            Nodes.Add(n123);
            Nodes.Add(n124);
            Nodes.Add(n125);
            Nodes.Add(n126);
            Nodes.Add(n127);
            Nodes.Add(n128);
            Nodes.Add(n129);
            Nodes.Add(n130);
            Nodes.Add(n131);
            Nodes.Add(n132);
            Nodes.Add(n133);
            Nodes.Add(n134);
            Nodes.Add(n135);
            Nodes.Add(n136);
            Nodes.Add(n137);
            Nodes.Add(n138);
            Nodes.Add(n139);
            Nodes.Add(n140);
            Nodes.Add(n141);
            Nodes.Add(n142);
            Nodes.Add(n143);
            Nodes.Add(n144);
            Nodes.Add(n145);
            Nodes.Add(n146);
            Nodes.Add(n147);
            Nodes.Add(n148);
            Nodes.Add(n149);
            Nodes.Add(n150);
            Nodes.Add(n151);
            Nodes.Add(n152);
            Nodes.Add(n153);
            Nodes.Add(n154);
            Nodes.Add(n155);
            Nodes.Add(n156);
            Nodes.Add(n157);
            Nodes.Add(n158);
            Nodes.Add(n159);
            Nodes.Add(n160);
            Nodes.Add(n161);
            Nodes.Add(n162);
            Nodes.Add(n163);
            Nodes.Add(n164);
            Nodes.Add(n165);
            Nodes.Add(n166);
            Nodes.Add(n167);
            Nodes.Add(n168);
            Nodes.Add(n169);
            Nodes.Add(n170);
            Nodes.Add(n171);
            Nodes.Add(n172);
            Nodes.Add(n173);
            Nodes.Add(n174);
            Nodes.Add(n175);
            Nodes.Add(n176);
            Nodes.Add(n177);
            Nodes.Add(n178);
            Nodes.Add(n179);
            Nodes.Add(n180);
            Nodes.Add(n181);
            Nodes.Add(n182);
            Nodes.Add(n183);
            Nodes.Add(n184);
            Nodes.Add(n185);
            Nodes.Add(n186);
            Nodes.Add(n187);
            Nodes.Add(n188);
            Nodes.Add(n189);
            Nodes.Add(n190);
            Nodes.Add(n191);
            Nodes.Add(n192);
            Nodes.Add(n193);
            Nodes.Add(n194);
            Nodes.Add(n195);
            Nodes.Add(n196);
            Nodes.Add(n197);
            Nodes.Add(n198);
            Nodes.Add(n199);
            Nodes.Add(n200);
            Nodes.Add(n201);
            Nodes.Add(n202);
            Nodes.Add(n203);
            Nodes.Add(n204);
            Nodes.Add(n205);
            Nodes.Add(n206);
            Nodes.Add(n207);
            Nodes.Add(n208);
            Nodes.Add(n209);
            Nodes.Add(n210);
            Nodes.Add(n211);
            Nodes.Add(n212);
            Nodes.Add(n213);
            Nodes.Add(n214);
            Nodes.Add(n215);
            Nodes.Add(n216);
            Nodes.Add(n217);
            Nodes.Add(n218);
            Nodes.Add(n219);
            Nodes.Add(n220);
            Nodes.Add(n221);
            Nodes.Add(n222);
            Nodes.Add(n223);
            Nodes.Add(n224);
            Nodes.Add(n225);
            Nodes.Add(n226);
            Nodes.Add(n227);
            Nodes.Add(n228);
            Nodes.Add(n229);
            Nodes.Add(n230);
            Nodes.Add(n231);
            Nodes.Add(n232);
            Nodes.Add(n233);
            Nodes.Add(n234);
            Nodes.Add(n235);
            Nodes.Add(n236);
            Nodes.Add(n237);
            Nodes.Add(n238);
            Nodes.Add(n239);
            Nodes.Add(n240);
            Nodes.Add(n241);
            Nodes.Add(n242);
            Nodes.Add(n243);
            Nodes.Add(n244);
            Nodes.Add(n245);
            Nodes.Add(n246);
            Nodes.Add(n247);
            Nodes.Add(n248);
            Nodes.Add(n249);
            Nodes.Add(n250);
            Nodes.Add(n251);
            Nodes.Add(n252);
            Nodes.Add(n253);
            Nodes.Add(n254);
            Nodes.Add(n255);
            Nodes.Add(n256);
            Nodes.Add(n257);
            #endregion 


            if (goleft == true)
            {
                pacman.Left -= playerSpeed;
                pacman.Image = Properties.Resources.left;
            }

            if (goright == true)
            {
                pacman.Left += playerSpeed;
                pacman.Image = Properties.Resources.right;
            }

            if (godown == true)
            {
                pacman.Top += playerSpeed;
                pacman.Image = Properties.Resources.down;
            }

            if (goup == true)
            {
                pacman.Top -= playerSpeed;
                pacman.Image = Properties.Resources.Up;
            }

            foreach (Control x in this.Controls)
            {
                if ((string)x.Tag == "coin" && x.Visible == true)
                    if (pacman.Bounds.IntersectsWith(x.Bounds))
                    {
                        score += 1;
                        x.Visible = false;
                    }
                if ((string)x.Tag == "Wall")
                {
                    if (pacman.Bounds.IntersectsWith(x.Bounds))
                    {
                        gameOver("Вы проиграли.");

                    }
                    if (redghost.Bounds.IntersectsWith(x.Bounds))
                    {
                        redGhostSpeedX = -redGhostSpeedY;
                        redGhostSpeedY = redGhostSpeedX;

                    }
                    if (yellowghost.Bounds.IntersectsWith(x.Bounds))
                    {
                        yellowGhostSpeedX = -yellowGhostSpeedY;
                        yellowGhostSpeedY = yellowGhostSpeedX;

                    }
                    if (pinkghost.Bounds.IntersectsWith(x.Bounds))
                    {
                        pinkGhostSpeedX = -pinkGhostSpeedY;
                        pinkGhostSpeedY = pinkGhostSpeedX;

                    }
                }

                if ((string)x.Tag == "ghost")
                    if (pacman.Bounds.IntersectsWith(x.Bounds))
                    {
                        gameOver("Вы проиграли.");
                    }


                if ((string)x.Tag == "Dot")
                {
                    if (pacman.Bounds.IntersectsWith(x.Bounds))
                    {
                        foreach (var node in Nodes)
                            if (node.Name == Convert.ToString(x.Top + "," + x.Left))
                                start = new Node(Convert.ToString(x.Top + "," + x.Left));
                    }
                    if (redghost.Bounds.IntersectsWith(x.Bounds))
                    {
                        foreach (var node in Nodes)
                            if (node.Name == Convert.ToString(x.Top + "," + x.Left))
                                endR = new Node(Convert.ToString(x.Top + "," + x.Left));
                    }
                    if (pinkghost.Bounds.IntersectsWith(x.Bounds))
                    {
                        foreach (var node in Nodes)
                            if (node.Name == Convert.ToString(x.Top + "," + x.Left))
                                endP = new Node(Convert.ToString(x.Top + "," + x.Left));
                    }
                    if (yellowghost.Bounds.IntersectsWith(x.Bounds))
                    {
                        foreach (var node in Nodes)
                            if (node.Name == Convert.ToString(x.Top + "," + x.Left))
                                endY = new Node(Convert.ToString(x.Top + "," + x.Left));
                    }
                    foreach (var dot in Dots())
                        dot.Visible = false;
                        switch (i)
                    {
                        case 0: //DFS
                            Stopwatch stopwatch1 = new Stopwatch();
                            stopwatch1.Start();
                            var search_DFS = new DepthFirstSearch();
                             var path_DFS = search_DFS.DFS(n112, n244);
                            stopwatch1.Stop();
                            label3.Text = "Алгоритм: DFS";
                            label2.Text = "Время: " + stopwatch1.ElapsedMilliseconds;
                            foreach (var dot in Dots())
                                foreach (var nod in path_DFS)
                                {
                                    if (nod.Name == Convert.ToString(dot.Top + "," + dot.Left))
                                    {
                                        dot.BackColor = Color.Red;
                                        dot.Visible = true;
                                    }
                                }
                            label3.Text = "Алгоритм: UCS";
                            break;
                        case 1://UCS                   
                            Stopwatch stopwatch2 = new Stopwatch();
                            stopwatch2.Start();
                            var search_UCS = new UniformCostSearch();
                            var path_UCS = search_UCS.UCS(n112, n233, 4);
                            stopwatch2.Stop();
                            label2.Text = "Время: " + stopwatch2.ElapsedMilliseconds;
                            foreach (var dot in Dots())
                                foreach (var nod in path_UCS)
                                {
                                    if (nod.Name == Convert.ToString(dot.Top + "," + dot.Left))
                                    {
                                        dot.BackColor = Color.Green;
                                        dot.Visible = true;
                                    }
                                }
                            label3.Text = "Алгоритм: UCS";
                            break;
                        case 2://BFS
                            Stopwatch stopwatch3 = new Stopwatch();
                            stopwatch3.Start();
                            var search_BFS = new BreadthFirstSearch();
                            var path_BFS = search_BFS.BFS(n112, n127);
                            stopwatch3.Stop();
                            label2.Text = "Время: " + stopwatch3.ElapsedMilliseconds;
                            label3.Text = "Алгоритм: BFS";
                            foreach (var dot in Dots())
                                foreach (var nod in path_BFS)
                                {
                                    if (nod.Name == Convert.ToString(dot.Top + "," + dot.Left))
                                    {
                                        dot.BackColor = Color.Yellow;
                                        dot.Visible = true;
                                    }
                                }
                            break;
                    }
                }


                redghost.Left += redGhostSpeedX;
                redghost.Top += redGhostSpeedY;

                pinkghost.Left += pinkGhostSpeedX;
                pinkghost.Top += pinkGhostSpeedY;

                yellowghost.Left += yellowGhostSpeedX;
                yellowghost.Top += yellowGhostSpeedY;

                if (score == 11)
                {
                    gameOver("Вы выиграли!");
                }

            }
        }

               #region ghostsLogicElements
        private void Logic(string m, bool intersect) //m = type of ghost
        #region GhostLogic
        {
            Random random = new Random();
            int i;
                i = random.Next(0, 5);
               
                if (pinkGhostSpeedX == 1 || redGhostSpeedX == 1 || yellowGhostSpeedX == 1)
                    switch (i)
                    {
                        case 1:
                            GoUp(m);
                            break;
                        case 2:
                            GoDown(m);
                            break;
                        case 3:
                            GoLeft(m);
                            break;
                        case 4:
                            GoRight(m);
                            break;
                    }
                if (pinkGhostSpeedX == -1 || redGhostSpeedX ==-1 || yellowGhostSpeedX == -1)
                    switch (i)
                    {
                        case 1:
                            GoUp(m);
                            break;
                        case 2:
                            GoDown(m);
                            break;
                        case 4:
                            GoRight(m);
                            break;
                    }
                if (pinkGhostSpeedY == 1 || redGhostSpeedY == 1 || yellowGhostSpeedY == 1)
                    switch (i)
                    {
                        case 1:
                            GoUp(m);
                            break;
                        case 3:
                            GoLeft(m);
                            break;
                        case 4:
                            GoRight(m);
                            break;
                    }
                if (pinkGhostSpeedY == -1 || redGhostSpeedY == -1 || yellowGhostSpeedY == -1)
                    switch (i)
                    {
                        case 2:
                            GoDown(m);
                            break;
                        case 3:
                            GoLeft(m);
                            break;
                        case 4:
                            GoRight(m);
                            break;
                    }
        }
        #endregion

        private void GoUp(string color)
        #region GoUp
        {
            if (color == "r")
            {
                redGhostSpeedX = 0;
                redGhostSpeedY = -1;
                redghost.Top += 10;
            }
            if (color == "y")
            {
                yellowGhostSpeedX = 0;
                yellowGhostSpeedY = -1;
                yellowghost.Top += 10;
            }
            if (color == "p")
            {
                pinkGhostSpeedX = 0;
                pinkGhostSpeedY = -1;
                pinkghost.Top += 10;
            }
        }
        #endregion

        private void GoLeft(string color)
        #region GoLeft
        {
            if (color == "r")
            {
                redGhostSpeedX = -1;
                redGhostSpeedY = 0;
                redghost.Left += 10;
            }
            if (color == "y")
            {
                yellowGhostSpeedX = -1;
                yellowGhostSpeedY = 0;
                yellowghost.Left += 10;
            }
            if (color == "p")
            {
                pinkGhostSpeedX = -1;
                pinkGhostSpeedY = 0;
                pinkghost.Left += 10;
            }
        }
        #endregion

        private void GoDown(string color)
        #region GoDown
        {
            if (color == "r")
            {
                redGhostSpeedY = 1;
                redGhostSpeedX = 0;
                redghost.Top -= 10;
            }
            if (color == "y")
            {
                yellowGhostSpeedY = 1;
                yellowGhostSpeedX = 0;
                yellowghost.Top -= 10;
            }
            if (color == "p")
            {
                pinkGhostSpeedX = 0;
                pinkGhostSpeedY = 1;
                pinkghost.Top -= 10;
            }
        }
        #endregion

        private void GoRight(string color)
        #region goRight
        {

            if (color == "r")
            {
                redGhostSpeedX = 1;
                redGhostSpeedY = 0;
                redghost.Left -= 10;
            }
            if (color == "y")
            {
                yellowGhostSpeedY = 0;
                yellowGhostSpeedX = 1;
                yellowghost.Left -= 10;
            }
            if (color == "p")
            {
                pinkGhostSpeedY = 0;
                pinkGhostSpeedX = 1;
                pinkghost.Left -= 10;
            }
        }
        #endregion



        #endregion


        private List<PictureBox> Boxes()
        #region PictureBoxes
        {
            List<PictureBox> Box = new List<PictureBox>();
            Box.Add(pictureBox5);
            Box.Add(pictureBox6);
            Box.Add(pictureBox7);
            Box.Add(pictureBox8);
            Box.Add(pictureBox9);
            Box.Add(pictureBox10);
            Box.Add(pictureBox11);
            Box.Add(pictureBox12);
            Box.Add(pictureBox13);
            Box.Add(pictureBox14);
            Box.Add(pictureBox15);
            Box.Add(pictureBox16);
            Box.Add(pictureBox17);
            Box.Add(pictureBox18);
            Box.Add(pictureBox19);
            Box.Add(pictureBox20);
            Box.Add(pictureBox21);
            Box.Add(pictureBox22);
            Box.Add(pictureBox23);
            Box.Add(pictureBox24);
            Box.Add(pictureBox25);
            Box.Add(pictureBox26);
            Box.Add(pictureBox27);
            Box.Add(pictureBox28);
            Box.Add(pictureBox29);
            Box.Add(pictureBox30);
            Box.Add(pictureBox31);
            Box.Add(pictureBox32);
            Box.Add(pictureBox33);
            Box.Add(pictureBox34);
            Box.Add(pictureBox35);
            Box.Add(pictureBox36);
            Box.Add(pictureBox40);
            Box.Add(pictureBox41);
            Box.Add(pictureBox42);
            Box.Add(pictureBox43);
            Box.Add(pictureBox44);
            Box.Add(pictureBox45);
            Box.Add(pictureBox46);
            Box.Add(pictureBox47);
            Box.Add(pictureBox49);
            Box.Add(pictureBox51);
            Box.Add(pictureBox52);
            Box.Add(pictureBox53);
            Box.Add(pictureBox54);
            Box.Add(pictureBox55);
            Box.Add(pictureBox56);
            Box.Add(pictureBox57);
            Box.Add(pictureBox58);
            Box.Add(pictureBox59);
            Box.Add(pictureBox60);
            Box.Add(pictureBox61);
            Box.Add(pictureBox62);
            Box.Add(pictureBox63);
            Box.Add(pictureBox64);
            Box.Add(pictureBox65);
            Box.Add(pictureBox66);
            Box.Add(pictureBox67);
            Box.Add(pictureBox68);
            Box.Add(pictureBox69);
            Box.Add(pictureBox71);
            Box.Add(pictureBox72);
            Box.Add(pictureBox73);
            Box.Add(pictureBox74);
            Box.Add(pictureBox75);

            return Box;
        }
        #endregion

        public List<PictureBox> Dots()
        #region DotsList
        {
            List<PictureBox> Dot = new List<PictureBox>();
            Dot.Add(pictureBox112);
            Dot.Add(pictureBox116);
            Dot.Add(pictureBox117);
            Dot.Add(pictureBox118);
            Dot.Add(pictureBox119);
            Dot.Add(pictureBox120);
            Dot.Add(pictureBox121);
            Dot.Add(pictureBox122);
            Dot.Add(pictureBox123);
            Dot.Add(pictureBox124);
            Dot.Add(pictureBox125);
            Dot.Add(pictureBox126);
            Dot.Add(pictureBox127);
            Dot.Add(pictureBox128);
            Dot.Add(pictureBox129);
            Dot.Add(pictureBox130);
            Dot.Add(pictureBox131);
            Dot.Add(pictureBox132);
            Dot.Add(pictureBox133);
            Dot.Add(pictureBox134);
            Dot.Add(pictureBox135);
            Dot.Add(pictureBox136);
            Dot.Add(pictureBox137);
            Dot.Add(pictureBox138);
            Dot.Add(pictureBox139);
            Dot.Add(pictureBox140);
            Dot.Add(pictureBox141);
            Dot.Add(pictureBox142);
            Dot.Add(pictureBox143);
            Dot.Add(pictureBox144);
            Dot.Add(pictureBox145);
            Dot.Add(pictureBox146);
            Dot.Add(pictureBox147);
            Dot.Add(pictureBox148);
            Dot.Add(pictureBox149);
            Dot.Add(pictureBox150);
            Dot.Add(pictureBox151);
            Dot.Add(pictureBox152);
            Dot.Add(pictureBox153);
            Dot.Add(pictureBox154);
            Dot.Add(pictureBox155);
            Dot.Add(pictureBox156);
            Dot.Add(pictureBox157);
            Dot.Add(pictureBox158);
            Dot.Add(pictureBox159);
            Dot.Add(pictureBox160);
            Dot.Add(pictureBox161);
            Dot.Add(pictureBox162);
            Dot.Add(pictureBox163);
            Dot.Add(pictureBox164);
            Dot.Add(pictureBox165);
            Dot.Add(pictureBox166);
            Dot.Add(pictureBox167);
            Dot.Add(pictureBox168);
            Dot.Add(pictureBox169);
            Dot.Add(pictureBox170);
            Dot.Add(pictureBox171);
            Dot.Add(pictureBox172);
            Dot.Add(pictureBox173);
            Dot.Add(pictureBox174);
            Dot.Add(pictureBox175);
            Dot.Add(pictureBox176);
            Dot.Add(pictureBox177);
            Dot.Add(pictureBox178);
            Dot.Add(pictureBox179);
            Dot.Add(pictureBox180);
            Dot.Add(pictureBox181);
            Dot.Add(pictureBox182);
            Dot.Add(pictureBox183);
            Dot.Add(pictureBox184);
            Dot.Add(pictureBox185);
            Dot.Add(pictureBox186);
            Dot.Add(pictureBox187);
            Dot.Add(pictureBox188);
            Dot.Add(pictureBox189);
            Dot.Add(pictureBox190);
            Dot.Add(pictureBox191);
            Dot.Add(pictureBox192);
            Dot.Add(pictureBox193);
            Dot.Add(pictureBox194);
            Dot.Add(pictureBox195);
            Dot.Add(pictureBox196);
            Dot.Add(pictureBox197);
            Dot.Add(pictureBox198);
            Dot.Add(pictureBox199);
            Dot.Add(pictureBox200);
            Dot.Add(pictureBox201);
            Dot.Add(pictureBox202);
            Dot.Add(pictureBox203);
            Dot.Add(pictureBox204);
            Dot.Add(pictureBox205);
            Dot.Add(pictureBox206);
            Dot.Add(pictureBox207);
            Dot.Add(pictureBox208);
            Dot.Add(pictureBox209);
            Dot.Add(pictureBox210);
            Dot.Add(pictureBox211);
            Dot.Add(pictureBox212);
            Dot.Add(pictureBox213);
            Dot.Add(pictureBox214);
            Dot.Add(pictureBox215);
            Dot.Add(pictureBox216);
            Dot.Add(pictureBox217);
            Dot.Add(pictureBox218);
            Dot.Add(pictureBox219);
            Dot.Add(pictureBox220);
            Dot.Add(pictureBox221);
            Dot.Add(pictureBox222);
            Dot.Add(pictureBox223);
            Dot.Add(pictureBox224);
            Dot.Add(pictureBox225);
            Dot.Add(pictureBox226);
            Dot.Add(pictureBox227);
            Dot.Add(pictureBox228);
            Dot.Add(pictureBox229);
            Dot.Add(pictureBox230);
            Dot.Add(pictureBox231);
            Dot.Add(pictureBox232);
            Dot.Add(pictureBox233);
            Dot.Add(pictureBox234);
            Dot.Add(pictureBox235);
            Dot.Add(pictureBox236);
            Dot.Add(pictureBox237);
            Dot.Add(pictureBox238);
            Dot.Add(pictureBox239);
            Dot.Add(pictureBox240);
            Dot.Add(pictureBox241);
            Dot.Add(pictureBox242);
            Dot.Add(pictureBox243);
            Dot.Add(pictureBox244);
            Dot.Add(pictureBox245);
            Dot.Add(pictureBox246);
            Dot.Add(pictureBox247);
            Dot.Add(pictureBox248);
            Dot.Add(pictureBox249);
            Dot.Add(pictureBox250);
            Dot.Add(pictureBox251);
            Dot.Add(pictureBox252);
            Dot.Add(pictureBox253);
            Dot.Add(pictureBox254);
            Dot.Add(pictureBox255);
            Dot.Add(pictureBox256);
            Dot.Add(pictureBox257);
            return Dot;
        }
        #endregion

        private void resetGame()
        {
            Random random = new Random();
            int value;

            foreach (var v in Boxes())
            {
                value = random.Next(1, 3);
                if (value == 2)
                {
                    v.Tag = "Wall";
                    v.BackColor = Color.Blue;
                }
            }

            foreach (var v in Boxes())
            {
                value = random.Next(1, 3);
                if (value == 2)
                {
                    v.Visible = true;
                    v.Tag = "goodWall";
                    v.BackColor = Color.Black;
                }
            }

            label1.Text = "Счёт: 0";
            score = 0;

            playerSpeed = 5;
            redGhostSpeedX = 0;
            redGhostSpeedY = 1;
            yellowGhostSpeedX = 1;
            yellowGhostSpeedY = 0;
            pinkGhostSpeedX = 0;
            pinkGhostSpeedY = -1;

            pacman.Left = 25;
            pacman.Top = 20;
            redghost.Left = 25;
            redghost.Top = 300;
            yellowghost.Left = 388;
            yellowghost.Top = 300;
            pinkghost.Left = 388;
            pinkghost.Top = 20;

            isGameOver = false;

            gameTimer.Start();

            foreach (Control x in this.Controls)
                if (x is PictureBox  && x.Tag == "coin")
                {
                    x.Visible = true;
                }
        }

        private void gameOver(string message)
        {
            isGameOver = true;

            gameTimer.Stop();

            label1.Text += "     " + message;
        }
    }

    class ListVisitedNodes
    {
         /*static void VisitedList (Node node)
        {
            foreach (var v in Dots())
                if (Convert.ToString(v.Top + "," +v.Left) == node.Name)
                    v.visible = true;
        }*/
            
            

    }

    class Node
    {
        public string Name { get; }
        public List<Node> Children { get; }

        public Node(string name)
        {
            Name = name;
            Children = new List<Node>();
        }

        public Node AddChildren(Node node, bool bidirect = true)
        {
            Children.Add(node);
            if (bidirect)
            {
                node.Children.Add(this);
            }
            return this;

        }

        List<string> Path = new List<string>();

        public void Pass()
        {
            Console.WriteLine(this.Name);
        }
    }

}


