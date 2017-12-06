using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2017
{
    class Program
    {
        static void Main(string[] args)
        {
            //dayOneFirstChallenge();
            //dayOneSecondChallenge();
            //dayTwoFirstChallenge();
            dayTwoSecondChallenge();
            Console.ReadKey();
        }

        private static void dayOneFirstChallenge()
        {
            string input = "428122498997587283996116951397957933569136949848379417125362532269869461185743113733992331379856446362482129646556286611543756564275715359874924898113424472782974789464348626278532936228881786273586278886575828239366794429223317476722337424399239986153675275924113322561873814364451339186918813451685263192891627186769818128715595715444565444581514677521874935942913547121751851631373316122491471564697731298951989511917272684335463436218283261962158671266625299188764589814518793576375629163896349665312991285776595142146261792244475721782941364787968924537841698538288459355159783985638187254653851864874544584878999193242641611859756728634623853475638478923744471563845635468173824196684361934269459459124269196811512927442662761563824323621758785866391424778683599179447845595931928589255935953295111937431266815352781399967295389339626178664148415561175386725992469782888757942558362117938629369129439717427474416851628121191639355646394276451847131182652486561415942815818785884559193483878139351841633366398788657844396925423217662517356486193821341454889283266691224778723833397914224396722559593959125317175899594685524852419495793389481831354787287452367145661829287518771631939314683137722493531318181315216342994141683484111969476952946378314883421677952397588613562958741328987734565492378977396431481215983656814486518865642645612413945129485464979535991675776338786758997128124651311153182816188924935186361813797251997643992686294724699281969473142721116432968216434977684138184481963845141486793996476793954226225885432422654394439882842163295458549755137247614338991879966665925466545111899714943716571113326479432925939227996799951279485722836754457737668191845914566732285928453781818792236447816127492445993945894435692799839217467253986218213131249786833333936332257795191937942688668182629489191693154184177398186462481316834678733713614889439352976144726162214648922159719979143735815478633912633185334529484779322818611438194522292278787653763328944421516569181178517915745625295158611636365253948455727653672922299582352766484";
            //string input = "1122";
            List<int> intsToSum = new List<int>();
            int outputNumber = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (i == input.Length - 1)
                {
                    if (input[i] == input[0])
                    {
                        int j = Convert.ToInt32(input[i].ToString());
                        Console.WriteLine(j);
                        intsToSum.Add(j);
                        Console.WriteLine("int count: {0}", intsToSum.Count);
                    }
                }
                else
                {
                    if (input[i] == input[i + 1])
                    {
                        int j = Convert.ToInt32(input[i].ToString());
                        Console.WriteLine(j);
                        intsToSum.Add(j);
                        Console.WriteLine("int count: {0}", intsToSum.Count);
                    }
                }
            }

            foreach (int e in intsToSum)
            {
                outputNumber += e;
                Console.WriteLine(outputNumber);
            }
        }

        private static void dayOneSecondChallenge()
        {
            string input = "428122498997587283996116951397957933569136949848379417125362532269869461185743113733992331379856446362482129646556286611543756564275715359874924898113424472782974789464348626278532936228881786273586278886575828239366794429223317476722337424399239986153675275924113322561873814364451339186918813451685263192891627186769818128715595715444565444581514677521874935942913547121751851631373316122491471564697731298951989511917272684335463436218283261962158671266625299188764589814518793576375629163896349665312991285776595142146261792244475721782941364787968924537841698538288459355159783985638187254653851864874544584878999193242641611859756728634623853475638478923744471563845635468173824196684361934269459459124269196811512927442662761563824323621758785866391424778683599179447845595931928589255935953295111937431266815352781399967295389339626178664148415561175386725992469782888757942558362117938629369129439717427474416851628121191639355646394276451847131182652486561415942815818785884559193483878139351841633366398788657844396925423217662517356486193821341454889283266691224778723833397914224396722559593959125317175899594685524852419495793389481831354787287452367145661829287518771631939314683137722493531318181315216342994141683484111969476952946378314883421677952397588613562958741328987734565492378977396431481215983656814486518865642645612413945129485464979535991675776338786758997128124651311153182816188924935186361813797251997643992686294724699281969473142721116432968216434977684138184481963845141486793996476793954226225885432422654394439882842163295458549755137247614338991879966665925466545111899714943716571113326479432925939227996799951279485722836754457737668191845914566732285928453781818792236447816127492445993945894435692799839217467253986218213131249786833333936332257795191937942688668182629489191693154184177398186462481316834678733713614889439352976144726162214648922159719979143735815478633912633185334529484779322818611438194522292278787653763328944421516569181178517915745625295158611636365253948455727653672922299582352766484";
            //string input = "1122";
            List<int> intsToSum = new List<int>();
            int outputNumber = 0;
            int offset = input.Length / 2;
            int offsetPointer = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (i + offset < input.Length)
                {
                    if (input[i] == input[i + offset])
                    {
                        int j = Convert.ToInt32(input[i].ToString());
                        Console.WriteLine(j);
                        intsToSum.Add(j);
                        Console.WriteLine("int count: {0}", intsToSum.Count);
                    }
                }
                else
                {
                    offsetPointer = (i + offset) - input.Length;
                    if (input[i] == input[offsetPointer])
                    {
                        int j = Convert.ToInt32(input[i].ToString());
                        Console.WriteLine(j);
                        intsToSum.Add(j);
                        Console.WriteLine("int count: {0}", intsToSum.Count);
                    }
                }
            }

            foreach (int e in intsToSum)
            {
                outputNumber += e;
                Console.WriteLine(outputNumber);
            }
        }

        private static void dayTwoFirstChallenge()
        {
            //string input = "3093    749 3469    142 2049    3537    1596    3035    2424    3982    3290    125 249 131 118 3138";

            string input = @"3093    749 3469    142 2049    3537    1596    3035    2424    3982    3290    125 249 131 118 3138
                             141 677 2705    2404    2887    2860    1123    2714    117 1157    2607    1800    153 130 1794    3272
                             182 93  2180    114 103 1017    95  580 2179    2470    2487    2806    1574    1325    1898    1706
                             3753    233 3961    3747    3479    3597    1303    2612    4043    1815    3318    737 197 3943    239 254
                             113 147 961 157 3514    3045    1270    3528    1369    3377    492 156 1410    3251    1839    1249
                             3948    3651    888 3631    253 220 4266    1284    3595    237 2138    3799    2319    254 267 1182
399 446 795 653 154 762 140 487 750 457 730 150 175 841 323 492
999 979 103 99  1544    1404    100 1615    840 92  1552    1665    1686    76  113 1700
4049    182 3583    1712    200 3326    3944    715 213 1855    2990    3621    2560    842 249 2082
2610    4749    2723    2915    2189    3911    124 164 1895    3095    3992    134 127 4229    3453    4428
105 692 101 150 193 755 84  185 622 851 706 251 86  408 774 831
238 217 224 1409    1850    2604    363 265 596 2933    2641    2277    803 2557    1399    237
304 247 192 4369    997 5750    85  1248    4718    3888    5228    5116    5880    5348    6052    245
238 373 228 395 86  59  289 87  437 384 233 79  470 403 441 352
151 3473    1435    87  1517    1480    140 2353    1293    118 163 3321    2537    3061    1532    3402
127 375 330 257 220 295 145 335 304 165 151 141 289 256 195 272";

            List<int> differences = new List<int>();
            List<string> outputLines = new List<string>();

            List<string> inputLines = input.Split(Environment.NewLine.ToCharArray()).ToList<string>();
            Console.WriteLine(inputLines.Count);
            for (int f = 0; f < inputLines.Count; f++)
            {
                //Console.WriteLine("*-*-*-*-");
                Console.WriteLine(inputLines[f].Length);
                if (inputLines[f].Length != 0)
                {
                    outputLines.Add(inputLines[f]);
                }
            }

            Console.WriteLine(outputLines.Count);

            for (int j = 0; j < outputLines.Count; j++)
            {
                List<string> inputStrings = outputLines[j].Split().ToList<string>();
                checksumGenerator(inputStrings, differences);
            }

            Console.WriteLine(differences[0]);
            int outputNumber = 0;
            for (int k = 0; k < differences.Count; k++)
            {
                outputNumber += differences[k];
                Console.WriteLine(outputNumber);
            }
            Console.WriteLine(outputNumber);
        }

        private static void dayTwoSecondChallenge()
        {
            string input = @"3093    749 3469    142 2049    3537    1596    3035    2424    3982    3290    125 249 131 118 3138
                             141 677 2705    2404    2887    2860    1123    2714    117 1157    2607    1800    153 130 1794    3272
                             182 93  2180    114 103 1017    95  580 2179    2470    2487    2806    1574    1325    1898    1706
                             3753    233 3961    3747    3479    3597    1303    2612    4043    1815    3318    737 197 3943    239 254
                             113 147 961 157 3514    3045    1270    3528    1369    3377    492 156 1410    3251    1839    1249
                             3948    3651    888 3631    253 220 4266    1284    3595    237 2138    3799    2319    254 267 1182
                             399 446 795 653 154 762 140 487 750 457 730 150 175 841 323 492
                             999 979 103 99  1544    1404    100 1615    840 92  1552    1665    1686    76  113 1700
                             4049    182 3583    1712    200 3326    3944    715 213 1855    2990    3621    2560    842 249 2082
                             2610    4749    2723    2915    2189    3911    124 164 1895    3095    3992    134 127 4229    3453    4428
                             105 692 101 150 193 755 84  185 622 851 706 251 86  408 774 831
                             238 217 224 1409    1850    2604    363 265 596 2933    2641    2277    803 2557    1399    237
                             304 247 192 4369    997 5750    85  1248    4718    3888    5228    5116    5880    5348    6052    245
                             238 373 228 395 86  59  289 87  437 384 233 79  470 403 441 352
                             151 3473    1435    87  1517    1480    140 2353    1293    118 163 3321    2537    3061    1532    3402
                             127 375 330 257 220 295 145 335 304 165 151 141 289 256 195 272";

            List<int> differences = new List<int>();
            List<string> outputLines = new List<string>();

            List<string> inputLines = input.Split(Environment.NewLine.ToCharArray()).ToList<string>();
            Console.WriteLine(inputLines.Count);
            for (int f = 0; f < inputLines.Count; f++)
            {
                //Console.WriteLine("*-*-*-*-");
                Console.WriteLine(inputLines[f].Length);
                if (inputLines[f].Length != 0)
                {
                    outputLines.Add(inputLines[f]);
                }
            }

            for (int j = 0; j < outputLines.Count; j++)
            {
                List<string> inputStrings = outputLines[j].Split().ToList<string>();
                checksumModuloGenerator(inputStrings, differences);
            }

            Console.WriteLine(differences[0]);
            int outputNumber = 0;
            for (int k = 0; k < differences.Count; k++)
            {
                outputNumber += differences[k];
                Console.WriteLine(outputNumber);
            }
            Console.WriteLine(outputNumber);
        }

        private static void checksumGenerator(List<string> inputList, List<int> outputDifferences)
        {
            List<int> outputs = new List<int>();
            for (int i = 0; i < inputList.Count; i++)
            {
                bool result = int.TryParse(inputList[i], out int outNumber);
                if (result)
                {
                    outputs.Add(outNumber);
                }

            }
            outputs.Sort();
            Console.WriteLine("Min: {0} Max: {1}", outputs[0], outputs[outputs.Count - 1]);
            outputDifferences.Add(outputs[outputs.Count - 1] - outputs[0]);
        }

        private static void checksumModuloGenerator(List<string> inputList, List<int> outputDifferences)
        {
            List<int> outputs = new List<int>();
            for (int i = 0; i < inputList.Count; i++)
            {
                bool result = int.TryParse(inputList[i], out int outNumber);
                if (result)
                {
                    outputs.Add(outNumber);
                }
            }
            for (int i = 0; i < outputs.Count; i++)
            {
                for (int h = 0; h < outputs.Count; h++)
                {
                    if (i != h)
                    {
                        if (outputs[i] % outputs[h] == 0)
                        {
                            Console.WriteLine("True");
                            outputDifferences.Add(outputs[i] / outputs[h]);
                        }
                    }
                }
            }
            //Console.WriteLine("Min: {0} Max: {1}", outputs[0], outputs[outputs.Count - 1]);
            //outputDifferences.Add(outputs[outputs.Count - 1] - outputs[0]);
        }
    }
}
