using System;
using System.Collections.Generic;
using System.Linq;
namespace BowlingGamePractice
    {
      public class BowlingGame
        	{

		    public Random Roll1 = new Random();
		    public Random Roll2 = new Random();
		    //public string GameStrike = "X";
        
        	public Dictionary<int, List<int>> FrameList = new Dictionary<int, List<int>>()
        		    {
        				{1, new List<int>(){}},
        			    {2, new List<int>(){}},
        			    {3, new List<int>(){}},
        			    {4, new List<int>(){}},
        			    {5, new List<int>(){}},
        			    {6, new List<int>(){}},
                        {7, new List<int>(){}},
                        {8, new List<int>(){}},
                        {9, new List<int>(){}},
                        {10, new List<int>(){}}
                       
        			};
            
    		public void GameRolls()
    		{
			    FrameList[1] = new List<int> { Roll1.Next(0,10), Roll2.Next(0,10) };
			    FrameList[2] = new List<int> { Roll1.Next(0, 10), Roll2.Next(0, 10) };
			    FrameList[3] = new List<int> { Roll1.Next(0, 10), Roll2.Next(0, 10) };
			    FrameList[4] = new List<int> { Roll1.Next(0, 10), Roll2.Next(0, 10) };
			    FrameList[5] = new List<int> { Roll1.Next(0, 10), Roll2.Next(0, 10) };
			    FrameList[6] = new List<int> { Roll1.Next(0, 10), Roll2.Next(0, 10) };
			    FrameList[7] = new List<int> { Roll1.Next(0, 10), Roll2.Next(0, 10) };
			    FrameList[8] = new List<int> { Roll1.Next(0, 10), Roll2.Next(0, 10) };
			    FrameList[9] = new List<int> { Roll1.Next(0, 10), Roll2.Next(0, 10) };
			    FrameList[10] = new List<int> { Roll1.Next(0, 10), Roll2.Next(0, 10) }; 
    		}    
                
            public void GameScore()
                {
                  foreach (KeyValuePair<int,List<int>>Frame in FrameList)
                		{
                		  Console.WriteLine($"Frame {Frame.Key}: {string.Join(", " , Frame.Value)} ");
                		}
                }
               

        	public void GameScoreTotal()
            	{
    			  double total = FrameList.Values.Sum(x => x.Sum());
    			  Console.WriteLine($"Total Score: {total}");
            			
            	}
            public void StrikeInGame()
		        {
			    if (Roll1.Next(0,10).Equals(10))
    			{
				    FrameList[1] = new List<int> { Roll1.Next(10, 10),Roll2.Next(0,0) };
                
    			}

		        }
                 
        	}
        }


