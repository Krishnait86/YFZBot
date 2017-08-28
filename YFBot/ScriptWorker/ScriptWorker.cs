﻿using System;
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
            string parseFile = System.IO.File.ReadAllText(fileName).Replace("\r\n", "");
            return parseFile.Split(new string[] { ";" }, StringSplitOptions.RemoveEmptyEntries);
        }

        private async Task<bool> logicWorker(string[] logicScript) {
            for (int i = 0; i < logicScript.Length; i++) {

                if (logicScript[i].Contains(" ")) {
                    string[] localParse = logicScript[i].Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);

                    switch (localParse[0]) {
                        /// <summary> Delay
                        /// 
                        /// </summary>                          
                        case "Delay":
                            await Task.Delay(Int32.Parse(localParse[1]));
                            break;
                        case "RandomDelay":
                            await Task.Delay(new Random().Next(Int32.Parse(localParse[1])));
                            break;
                        /// <summary> Jumps
                        /// 
                        /// </summary>
                        case "StepUp":
                            i = i - Int32.Parse(localParse[1]);
                            break;
                        case "StepDown":
                            i = i + Int32.Parse(localParse[1]);
                            break;

                        default:
                            break;
                    }
                }
                else {
                    switch (logicScript[i]) {
                        /// <summary> Movement 
                        /// 
                        /// </summary>
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


                        default:
                            break;
                    }
                }                
            }
            return true;
        }
    }
}
