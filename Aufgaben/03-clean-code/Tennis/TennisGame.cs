using static System.Formats.Asn1.AsnWriter;

namespace Tennis
{
    public class TennisGameManager
    {
        private int p1point = 0;
        private int p2point = 0;

        private string p1res = "";
        private string p2res = "";

        public string Score_Getter()
        {
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

            //p2 has no points: love
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
            if (p2point > 0 && p1point == 0)
            {
                var temp = p2point;
                if (temp == 1) 
                    p2res = "Fifteen";
                if (temp == 2) 
                    p2res = "Thirty";
                if (temp == 3) 
                    p2res = "Forty";

                p1res = "Love";
                ResultingString = p1res + "-" + p2res;
            }
            if (p1point > p2point && p1point < 4)
            {
                if (p1point == 2)
                    p1res = "Thirty";
                if (p1point == 3)
                    p1res = "Forty";
                if (p2point == 1)
                    p2res = "Fifteen";
                if (p2point == 2)
                    p2res = "Thirty";

                ResultingString = p1res + "-" + p2res;
            }

            if (p2point > p1point && p2point < 4)
            {
                if (p2point ==   2)
                    p2res = "Thirty";
                if (p2point == 3)
                    p2res = "Forty";
                if (p1point == 1 )
                    p1res = "Fifteen";
                if (p1point == 2)
                    p1res = "Thirty";
                ResultingString = p1res + "-" + p2res;
            }

            if (p1point > p2point && p2point >= 3)
            {
                ResultingString = "Advantage player1";
            }

            if (p2point > p1point && p1point >= 3)
            {
                ResultingString = generate_Player_2_Name();
            }

            if (p1point >= 4 && p2point >= 0 && (p1point - p2point) >= 2)
            {
                ResultingString = "Win for player1";
            }
            ResultingString = returnWinForPlayerOneIfWon(ResultingString, p1point, p2point);
            return ResultingString;
        }

        private static string generate_Player_2_Name()
        {
            return "Advantage player2";
        }

        public string returnWinForPlayerOneIfWon(string s, int q, int y)
        {
            if (y >= 4 && q >= 0 && (y - q) >= 2)
            {
                return "Win for player2";
            }
            return s; 
        }

        public void SetPlayer1Score(int number)
        {
            for (int i = 0; i < number; i++)
            {
                p1point++;
            }
        }

        public void SetP2Score(int number)
        {
            for (var i = 0; i < number; i++)
            {
                p2point++;
            }
        }

        public void WonPoint(string tennisPlayer)
        {
            if (tennisPlayer == "player1") p1point++;
            else p2point++;
        }

    }
}

