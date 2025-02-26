using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NAudio.Wave;
using NAudio.CoreAudioApi;

namespace 콘솔좌표
{
    class Program
    {
        static async Task Main(string[] args)
        {
            //콘솔창 크기, 버퍼크기 설정
            Console.SetWindowSize(80, 25);
            Console.SetBufferSize(80, 25);

            //콘솔 좌표
            //Console.SetCursorPosition(10, 5);

            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Random rand = new Random();

            int gold = 500;
            int health = 100;
            int power = 10;
            int input;
            bool isAlive = true;

            // 사운드 비동기 재생
            var audioTask = PlayBackgroundMusicAsync("C:\\Users\\asdgh\\OneDrive\\바탕 화면\\Study\\LikeLion\\콘솔좌표\\background.mp3");

            SoundPlayer Coin = new SoundPlayer("C:\\Users\\asdgh\\OneDrive\\바탕 화면\\Study\\LikeLion\\콘솔좌표\\Coin 1.wav");
            SoundPlayer healM = new SoundPlayer("C:\\Users\\asdgh\\OneDrive\\바탕 화면\\Study\\LikeLion\\콘솔좌표\\Correct 1.wav");
            SoundPlayer buy = new SoundPlayer("C:\\Users\\asdgh\\OneDrive\\바탕 화면\\Study\\LikeLion\\콘솔좌표\\MP_맑은 벨 알림음 - 7.wav");
            SoundPlayer attack = new SoundPlayer("C:\\Users\\asdgh\\OneDrive\\바탕 화면\\Study\\LikeLion\\콘솔좌표\\MP_Jab.wav");
            

            Console.Title = "콘솔 게임";

            Console.CursorVisible = false;

            string[] title = { "┎━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┒",
                               "┃                                                                              ┃",
                               "┃                                                                              ┃",
                               "┃                                                                              ┃",
                               "┃                                                                              ┃",
                               "┃                                                                              ┃",
                               "┃                                                                              ┃",
                               "┃                                                                              ┃",
                               "┃                                                                              ┃",
                               "┃                  모험가 키우기 게임에 오신 것을 환영합니다 !                 ┃",
                               "┃                                                                              ┃",
                               "┃                                                                              ┃",
                               "┃                                                                              ┃",
                               "┃                                                                              ┃",
                               "┃                                                                              ┃",
                               "┃                                                                              ┃",
                               "┃                                                                              ┃",
                               "┃                                                                              ┃",
                               "┃                                                                              ┃",
                               "┃                                                                              ┃",
                               "┃                                                                              ┃",
                               "┃                                                                              ┃",
                               "┃                                                                              ┃",
                               "┖━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┚"};

            for (int i = 0; i < title.Length; i++)
            {
                Console.SetCursorPosition(0, i);
                Console.WriteLine(title[i]);
            }
            Thread.Sleep(1000);

            while (isAlive)
            {
                Console.Clear();
                title[9] = "┃                                                                              ┃";
                title[10] = $"┃ 현재 상태: 체력 {health}. 골드 : {gold}, 공격력 : {power}                                 ┃";
                title[11] = "┃  1.모험하기 \\t2.장비 뽑기 (1000) \\t3.휴식하기 (체력 +20) \\t4.게임 종료       ┃";
                for (int i = 0; i < title.Length; i++)
                {
                    Console.SetCursorPosition(0, i);
                    Console.WriteLine(title[i]);
                }
                //Console.WriteLine($" 현재 상태: 체력 {health}. 골드 : {gold}, 공격력 : {power}");
                //Console.WriteLine("1.모험하기 \t2.장비 뽑기 (1000) \t3.휴식하기 (체력 +20) \t4.게임 종료");
                Console.Write("선택 : ");
                input = int.Parse(Console.ReadLine());

                if (input == 1)
                {
                    Console.Clear();
                    title[10] = "┃                                                                              ┃";
                    title[11] = "┃                                                                              ┃";
                    title[9] = "┃                                모험을 떠납니다.                                     ┃";

                    for (int i = 0; i < title.Length; i++)
                    {
                        Console.SetCursorPosition(0, i);
                        Console.WriteLine(title[i]);
                    }

                    int eventChance = rand.Next(1, 101);

                    if (eventChance <= 30)
                    {
                        int damage = rand.Next(5, 21);
                        attack.Play();
                        title[9] = $"┃              몬스터를 만났습니다! -{damage}의 데미지를 입었습니다.                 ┃";
                        health -= damage;
                    }
                    else if (eventChance <= 70)
                    {
                        int reward = rand.Next(100, 1001);
                        Coin.Play();
                        title[9] = $"┃              보물상자를 찾았습니다! {reward}의 골드를 획득했습니다.               ┃";
                        gold += reward;
                    }
                    else
                    {
                        int heal = rand.Next(10, 31);
                        healM.Play();
                        title[9] = $"┃              회복의 성소를 발견했습니다. {heal}의 체력을 회복했습니다.           ┃";
                        health += heal;
                    }

                    for (int i = 0; i < title.Length; i++)
                    {
                        Console.SetCursorPosition(0, i);
                        Console.WriteLine(title[i]);
                    }
                    Thread.Sleep(1000);

                    title[10] = $"┃ 현재 상태: 체력 {health}. 골드 : {gold}, 공격력 : {power}                                   ┃";
                    title[11] = "┃  1.모험하기 \\t2.장비 뽑기 (1000) \\t3.휴식하기 (체력 +20) \\t4.게임 종료       ┃";

                }
                else if (input == 2)
                {
                    if (gold >= 1000)
                    {
                        buy.Play();
                        gold -= 1000;
                        Console.Clear();
                        title[10] = "┃                                                                              ┃";
                        title[11] = "┃                                                                              ┃";
                        title[9] = "┃                                장비를 뽑습니다.                                     ┃";
                        for (int i = 0; i < title.Length; i++)
                        {
                            Console.SetCursorPosition(0, i);
                            Console.WriteLine(title[i]);
                        }
                        Thread.Sleep(500);

                        int rnd = rand.Next(1, 100);
                        if (rnd == 1)
                        {
                            title[9] = "┃      태초 아이템을 획득했습니다. 공격력 +100                                        ┃";
                            Console.WriteLine("태초 아이템을 획득했습니다. 공격력 +100");
                            power += 100;
                            for (int i = 0; i < title.Length; i++)
                            {
                                Console.SetCursorPosition(0, i);
                                Console.WriteLine(title[i]);
                            }
                            Thread.Sleep(500);
                        }
                        else if (rnd <= 10)
                        {
                            title[9] = "┃      에픽 아이템을 획득했습니다. 공격력 +60                                         ┃";
                            power += 60;
                            for (int i = 0; i < title.Length; i++)
                            {
                                Console.SetCursorPosition(0, i);
                                Console.WriteLine(title[i]);
                            }
                            Thread.Sleep(500);
                        }
                        else if (rnd <= 30)
                        {
                            title[9] = "┃      레전더리 아이템을 획득했습니다. 공격력 +40                                       ┃";
                            power += 40;
                            for (int i = 0; i < title.Length; i++)
                            {
                                Console.SetCursorPosition(0, i);
                                Console.WriteLine(title[i]);
                            }
                            Thread.Sleep(500);
                        }
                        else if (rnd <= 70)
                        {
                            title[9] = "┃      유니크 아이템을 획득했습니다. 공격력 +20                                        ┃";
                            power += 20;
                            for (int i = 0; i < title.Length; i++)
                            {
                                Console.SetCursorPosition(0, i);
                                Console.WriteLine(title[i]);
                            }
                            Thread.Sleep(500);
                        }
                        else
                        {
                            title[9] = "┃      레어 아이템을 획득했습니다. 공격력 +10                                        ┃";
                            power += 10;
                            for (int i = 0; i < title.Length; i++)
                            {
                                Console.SetCursorPosition(0, i);
                                Console.WriteLine(title[i]);
                            }
                            Thread.Sleep(500);
                        }
                    }
                    else
                    {
                        title[9] = "┃                                골드가 부족합니다.                                     ┃";
                        for (int i = 0; i < title.Length; i++)
                        {
                            Console.SetCursorPosition(0, i);
                            Console.WriteLine(title[i]);
                        }
                        Thread.Sleep(500);
                    }
                }
                else if (input == 3)
                {
                    title[9] = "┃                                휴식을 취합니다.                                     ┃";
                    health += 20;
                    healM.Play();
                    for (int i = 0; i < title.Length; i++)
                    {
                        Console.SetCursorPosition(0, i);
                        Console.WriteLine(title[i]);
                    }
                    Thread.Sleep(500);
                }
                else if (input == 4)
                {
                    title[9] = "┃                                게임을 종료합니다.                                    ┃";
                    for (int i = 0; i < title.Length; i++)
                    {
                        Console.SetCursorPosition(0, i);
                        Console.WriteLine(title[i]);
                    }
                    Thread.Sleep(500);
                    Environment.Exit(1);
                }
                else
                {
                    Console.WriteLine("잘못된 선택입니다.");
                    Thread.Sleep(500);
                }

                if (health <= 0)
                {
                    Console.WriteLine("체력이 0이 되어 사망하였습니다.");
                    isAlive = false;
                    Thread.Sleep(500);
                }

            }

            await audioTask;
        }

        static void printScreen(String title)
        {
            for (int i = 0; i < title.Length; i++)
            {
                Console.SetCursorPosition(0, i);
                Console.WriteLine(title[i]);
            }
        }

        static async Task PlayBackgroundMusicAsync(string filePath)
        {
            using (var audioFile = new AudioFileReader(filePath))
            using (var outputDevice = new WaveOutEvent())
            {
                outputDevice.Init(audioFile);
                outputDevice.Play();

                // 루프 재생을 원할 경우
                outputDevice.PlaybackStopped += (sender, e) => outputDevice.Play();

                // 음악이 끝날 때까지 대기
                while (outputDevice.PlaybackState == PlaybackState.Playing)
                {
                    await Task.Delay(1000);
                }
            }
        }
    }
}
