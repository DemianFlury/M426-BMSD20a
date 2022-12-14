using static System.Formats.Asn1.AsnWriter;

namespace Tennis
{
    public class TennisGameManager
    {

        public string Score_Getter()
        {
            int p1point = 0, p2point = 0;
            string p1res = "", p2res = "";
            string ResultingString = "";
            // when both have same points
            if (p1point == p2point)
            {
                //less than three points: add "-All" to the string
                if (p1point == 0)
                    ResultingString = "Love";
                else if (p1point == 1)
                    ResultingString = "Fifteen";
                else if (p1point == 2)
                    ResultingString = "Thirty";

                ResultingString += "-All";

                //more than three points: deuce
                if (p1point >= 3)
                    ResultingString = "Deuce";
            }

            //p2 has no points: x-love
            if (p1point > 0 && p2point == 0)
            {
                if (p1point == 1)
                    p1res = "Fifteen";
                if (p1point == 2)
                    p1res = "Thirty";
                if (p1point == 3)
                    p1res = "Forty";

                p2res = "Love";
                ResultingString = p1res + "-" + p2res;
            }

            //p1 has no points: love-x
            else if (p2point > 0 && p1point == 0)
            {

                if (p2point == 1)
                    p2res = "Fifteen";
                if (p2point == 2)
                    p2res = "Thirty";
                if (p2point == 3)
                    p2res = "Forty";

                p1res = "Love";
                ResultingString = p1res + "-" + p2res;
            }

            //both players have points x-x
            else if (p1point > 0 && p2point > 0 && p1point != p2point)
            {
                switch (p1point)
                {
                    case 1:
                        p1res = "Fifteen";
                        break;
                    case 2:
                        p1res = "Thirty";
                        break;
                    case 3:
                        p1res = "Forty";
                        break;
                }

                switch (p2point)
                {
                    case 1:
                        p2res = "Fifteen";
                        break;
                    case 2:
                        p2res = "Thirty";
                        break;
                    case 3:
                        p2res = "Forty";
                        break;
                }

                ResultingString = p1res + "-" + p2res;
            }

            if (p1point > p2point && p2point >= 3)
            {
                ResultingString = "Advantage player1";
            }

            if (p2point > p1point && p1point >= 3)
            {
                ResultingString = "Advantage player2";
            }

            if (p1point >= 4 && p2point >= 0 && (p1point - p2point) >= 2)
            {
                ResultingString = "Win for player1";
            }
            ResultingString = returnWinningPlayer(ResultingString, p1point, p2point);
            return ResultingString;
        }

        public string returnWinningPlayer(string Result, int p1Points, int p2Points)
        {
            if (p2Points >= 4 && (p2Points - p1Points) >= 2)
            {
                Result = "Win for player2";
            }
            else if(p1Points >= 4 && (p1Points - p2Points) >= 2)
            {
                Result = "Win for player1";
            }
            return Result;
        }

        public void WonPoint(string tennisPlayer)
        {
            if (tennisPlayer == "player1") p1point++;
            else p2point++;
        }
    }
}

