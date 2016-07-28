using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 飞行棋游戏
{
    class Program
    {
        public static int[] Maps = new int[100];
        //申明一个静态数组来存放玩家A和玩家B的坐标
        public static int[] PlayerPos = new int[2];
        public static string[] PlayerNames = new string[2];
        //两个玩家的标记
        static bool[] Flags = new bool[2];//Flags[0]默认是false  Flags[1]默认也是false
        static void Main(string[] args)
        {
            GameShow();
            #region 输入玩家姓名
            Console.WriteLine("请输入玩家A的姓名：");
            PlayerNames[0] = Console.ReadLine();
            while (PlayerNames[0] == "")
            {
                Console.WriteLine("玩家的A姓名不能为空，请重新输入！");
                PlayerNames[0] = Console.ReadLine();
            }
            Console.WriteLine("请输入玩家B的姓名：");
            PlayerNames[1] = Console.ReadLine();
            while (PlayerNames[1] == "" || PlayerNames[0] == PlayerNames[1])
            {
                if (PlayerNames[1] == "")
                {
                    Console.WriteLine("玩家B的姓名不能为空，请重新输入！");
                    PlayerNames[1] = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("玩家B的姓名不能和玩家A的姓名相同，请重新输入！");
                    PlayerNames[1] = Console.ReadLine();
                }
            } 
            #endregion
            Console.Clear();
            GameShow();
            Console.WriteLine("{0}的士兵用A表示", PlayerNames[0]);
            Console.WriteLine("{0}的士兵用B表示", PlayerNames[1]);
            InitailMap();
            DrawMap();
            while (PlayerPos[0]<99&PlayerPos[1]<99)
            {
                if (Flags[0] == false)
                {
                    PlayGame(0);//Flags[0]=true;
                }
                else
                {
                    Flags[0] = false;
                }
                if (PlayerPos[0] >= 99)
                {
                    Console.WriteLine("玩家{0}无耻的赢了玩家{1}",PlayerNames[0],PlayerNames[1]);
                    break;
                }
                if (Flags[1] == false)
                {
                    PlayGame(1);
                }
                else
                {
                    Flags[1] = false;
                }
                if (PlayerPos[1] >= 99)
                {
                    Console.WriteLine("玩家{0}无耻的赢了玩家{1}", PlayerNames[1], PlayerNames[0]);
                    break;
                }
            }
            Win();
            Console.ReadKey();
        }
        /// <summary>
        /// 游戏头
        /// </summary>
        public static void GameShow()
        {
            Console.WriteLine("********************");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("********************");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("********************");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("***飞行棋游戏V1.2***");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("********************");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("********************");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("********************");
        }
        /// <summary>
        /// 初始化地图
        /// </summary>
        public static void InitailMap()
        {
            int[] luckyturn = { 6, 23, 40, 55, 69, 83 };//幸运轮盘◎
            for (int i = 0; i < luckyturn.Length; i++)
            {
                Maps[luckyturn[i]] = 1;
            }
            int[] landMine = { 5, 13, 17, 33, 38, 50, 64, 80, 94 };//地雷☆
            for (int i = 0; i < landMine.Length; i++)
            {
                Maps[landMine[i]] = 2;
            }
            int[] pause = { 9, 27, 60, 93 };//暂停▲
            for (int i = 0; i < pause.Length; i++)
            {
                Maps[pause[i]] = 3;
            }
            int[] timeTunnel = { 20, 25, 45, 63, 72, 88, 90 };//时空隧道卐
            for (int i = 0; i < timeTunnel.Length; i++)
            {
                Maps[timeTunnel[i]] = 4;
            }
        }
        public static void DrawMap()
        {
            Console.WriteLine("图例:幸运轮盘:◎   地雷:☆   暂停:▲   时空隧道:卐");
            #region 第一横行
            for (int i = 0; i < 30; i++)
            {
                Console.Write(DrawStringMap(i));
            }
            Console.WriteLine();
            #endregion
            #region 第一竖行
            for (int i = 30; i < 35; i++)
            {
                for (int j = 0; j <= 28; j++)
                {
                    Console.Write("  ");
                }
                Console.Write(DrawStringMap(i));
                Console.WriteLine();
            }
            #endregion
            #region 第二横行
            for (int i = 64; i >= 35; i--)
            {
                Console.Write(DrawStringMap(i));
            }
            Console.WriteLine();
            #endregion
            #region 第二竖行
            for (int i = 65; i <= 69; i++)
            {
                Console.WriteLine(DrawStringMap(i));
            } 
            #endregion
            #region 第三横行
            for (int i = 70; i < 100; i++)
            {
                Console.Write(DrawStringMap(i));
            }
            Console.WriteLine();
            #endregion
        }
        /// <summary>
        /// 从画地图中抽象出的一个方法
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public static string DrawStringMap(int i)
        {
            string str = "";
            //如果玩家A跟玩家B的坐标相同，并且都在这个地图上，画一个尖括号
            if (PlayerPos[0] == PlayerPos[1] && PlayerPos[0] == i)
            {
                str = "<>";
            }
            else if (PlayerPos[0] == i)
            {
                str = "Ａ";
            }
            else if (PlayerPos[1] == i)
            {
                str = "Ｂ";
            }
            else
            {
                switch (Maps[i])
                {
                    case 0:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        str = "□";
                        break;
                    case 1:
                        Console.ForegroundColor = ConsoleColor.Green;
                        str = "◎";
                        break;
                    case 2:
                        Console.ForegroundColor = ConsoleColor.Red;
                        str = "☆";
                        break;
                    case 3:
                        Console.ForegroundColor = ConsoleColor.Blue;
                        str = "▲";
                        break;
                    case 4:
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        str = "卐";
                        break;
                }
            }
            return str;
        }
        public static void Win()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("                                          ◆                      ");
            Console.WriteLine("                    ■                  ◆               ■        ■");
            Console.WriteLine("      ■■■■  ■  ■                ◆■         ■    ■        ■");
            Console.WriteLine("      ■    ■  ■  ■              ◆  ■         ■    ■        ■");
            Console.WriteLine("      ■    ■ ■■■■■■       ■■■■■■■   ■    ■        ■");
            Console.WriteLine("      ■■■■ ■   ■                ●■●       ■    ■        ■");
            Console.WriteLine("      ■    ■      ■               ● ■ ●      ■    ■        ■");
            Console.WriteLine("      ■    ■ ■■■■■■         ●  ■  ●     ■    ■        ■");
            Console.WriteLine("      ■■■■      ■             ●   ■   ■    ■    ■        ■");
            Console.WriteLine("      ■    ■      ■            ■    ■         ■    ■        ■");
            Console.WriteLine("      ■    ■      ■                  ■               ■        ■ ");
            Console.WriteLine("     ■     ■      ■                  ■           ●  ■          ");
            Console.WriteLine("    ■    ■■ ■■■■■■             ■              ●         ●");
            Console.ResetColor();
        }
        public static void PlayGame(int playerNumber)
        {
            Random r = new Random();
            int rNumber = r.Next(1, 7);
            Console.WriteLine("{0}按任意键开始掷骰子", PlayerNames[playerNumber]);
            Console.ReadKey(true);
            Console.WriteLine("{0}掷出了{1}", PlayerNames[playerNumber], rNumber);
            PlayerPos[playerNumber] += rNumber;
            ChangePos();
            Console.ReadKey(true);
            Console.WriteLine("{0}按任意键开始行动", PlayerNames[playerNumber]);
            Console.ReadKey(true);
            Console.WriteLine("{0}行动完了", PlayerNames[playerNumber]);
            Console.ReadKey(true);
            //玩家A有可能踩到了玩家B 方块 幸运轮盘 地雷 暂停 时空隧道
            if (PlayerPos[playerNumber] == PlayerPos[1 - playerNumber])
            {
                Console.WriteLine("玩家{0}踩到了玩家{1}，玩家{2}退6格", PlayerNames[playerNumber], PlayerNames[1 - playerNumber], PlayerNames[1 - playerNumber]);
                PlayerPos[1 - playerNumber] -= 6;
                ChangePos();
                Console.ReadKey(true);
            }
            else//踩到了关卡
            {
                //玩家的坐标
                switch (Maps[PlayerPos[playerNumber]])// 0 1 2 3 4
                {
                    case 0: Console.WriteLine("玩家{0}踩到了方块，安全。", PlayerNames[playerNumber]);
                        Console.ReadKey(true);
                        break;
                    case 1: Console.WriteLine("玩家{0}踩到了幸运轮盘，请选择 1--交换位置 2--轰炸对方", PlayerNames[playerNumber]);
                        string input = Console.ReadLine();
                        while (true)
                        {
                            if (input == "1")
                            {
                                Console.WriteLine("玩家{0}选择跟玩家{1}交换位置", PlayerNames[playerNumber], PlayerNames[1 - playerNumber]);
                                Console.ReadKey(true);
                                int temp = PlayerPos[playerNumber];
                                PlayerPos[playerNumber] = PlayerPos[1 - playerNumber];
                                PlayerPos[1 - playerNumber] = temp;
                                Console.WriteLine("交换完成！！！按任意键继续游戏！！！");
                                Console.ReadKey(true);
                                break;
                            }
                            else if (input == "2")
                            {
                                Console.WriteLine("玩家{0}选择轰炸玩家{1},玩家{2}退6格", PlayerNames[playerNumber], PlayerNames[1 - playerNumber], PlayerNames[1 - playerNumber]);
                                Console.ReadKey(true);
                                PlayerPos[1 - playerNumber] -= 6;
                                ChangePos();
                                Console.WriteLine("玩家{0}退了6格", PlayerNames[1 - playerNumber]);
                                Console.ReadKey(true);
                                break;
                            }
                            else
                            {
                                Console.WriteLine("只能输入1或者2  1--交换位置 2--轰炸对方");
                                input = Console.ReadLine();
                            }
                        }
                        break;
                    case 2: Console.WriteLine("玩家{0}踩到了地雷,退6格", PlayerNames[playerNumber]);
                        Console.ReadKey(true);
                        PlayerPos[playerNumber] -= 6;
                        ChangePos();
                        break;
                    case 3: Console.WriteLine("玩家{0}踩到了暂停，暂停一回合", PlayerNames[playerNumber]);
                        Flags[playerNumber] = true;
                        Console.ReadKey(true);
                        break;
                    case 4: Console.WriteLine("玩家{0}踩到了时空隧道，前进10格", PlayerNames[playerNumber]);
                        PlayerPos[playerNumber] += 10;
                        ChangePos();
                        Console.ReadKey(true);
                        break;
                }//switch
            }//else
            ChangePos();//perfect
            Console.Clear();
            DrawMap();
        }
        public static void ChangePos()
        {
            if (PlayerPos[0] < 0)
            {
                PlayerPos[0] = 0;
            }
            if (PlayerPos[0] >= 99)
            {
                PlayerPos[0] = 99;
            }

            if (PlayerPos[1] < 0)
            {
                PlayerPos[1] = 0;
            }
            if (PlayerPos[1] >= 99)
            {
                PlayerPos[1] = 99;
            }
        }

    }
}
