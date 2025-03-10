using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAudio.Wave;

namespace TextRPGTest
{
    class MainGame
    {
        private IWavePlayer waveOut;
        private AudioFileReader audioFileReader;

        Player player = null;
        Info Monster = new Monster();
        Field field = null;
        private void OnPlaybackStopped(object sender, StoppedEventArgs e)
        {
            // 음악이 끝나면 다시 재생
            audioFileReader.Position = 0;
            waveOut.Play();
        }
        public void Initial()
        {
            waveOut = new WaveOutEvent();
            audioFileReader = new AudioFileReader("C:\\Users\\asdgh\\OneDrive\\바탕 화면\\Study\\LikeLion\\TextRPGTest\\10℃_2.mp3");
            audioFileReader.Volume = 0.1f; // 볼륨 조절
            waveOut.Init(audioFileReader);
            waveOut.Play();
            waveOut.PlaybackStopped += OnPlaybackStopped;

            if (player == null) { player = new Player(); }
            player.SelectJop();

        }

        public void Progress()
        {
            int input = 0;

            while (true)
            {
                Console.Clear();
                player.Render();
                Console.WriteLine("==================================");
                Console.WriteLine("1.사냥터\t 2.종료");
                Console.WriteLine("==================================");
                Console.Write("입력 : ");
                input = int.Parse(Console.ReadLine());

                if (input == 2) Environment.Exit(0);
                else if (input == 1)
                {
                    if (field == null)
                    {
                        field = new Field();
                        field.SetPlayer(player);
                    }
                    field.GoField();

                }
            }


        }



        public void StopMusic()
        {
            waveOut.Stop();
            audioFileReader.Dispose();
            waveOut.Dispose();
        }
    }


}
