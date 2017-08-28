using System;
using System.Threading.Tasks;
using YFBot.Movement;

namespace YFBot.ScriptWorker {
    class ScriptWorker {
        Move move = new Move();
        
        public string FileName { get; set; }

        public ScriptWorker() { }

        public async Task<bool> LoadScript() {
            return await logicWorker(pharceFile(FileName));
            
        }

        private string[] pharceFile(string fileName) {
            string pharseFile = System.IO.File.ReadAllText(fileName).Replace("\r\n", "").Trim();
            return pharseFile.Split(new string[] { ";", " " }, StringSplitOptions.RemoveEmptyEntries);
        }

        private async Task<bool> logicWorker(string[] logicScript) {
            for (int i = 0; i < logicScript.Length; i++) {
                switch (logicScript[i]) {
                    case "Forward":
                        move.Go(Direction.Forward);
                        break;
                    case "Back":
                        move.Go(Direction.Backward);
                        break;
                    case "Right":
                        move.Go(Direction.Right);
                        break;
                    case "Left":
                        move.Go(Direction.Left);
                        break;
                    case "Stop":
                        move.Go(Direction.Stop);
                        break;
                    case "Delay":
                        await Task.Delay(Int32.Parse(logicScript[i + 1]));
                        i++;
                        break;
                    case "RandomDelay":
                        await Task.Delay(new Random().Next(Int32.Parse(logicScript[i + 1])));
                        i++;
                        break;

                    default:
                        break;
                }                
            }
            return true;
        }
    }
}
