namespace exercise_119
{
  public class Timer
  {
        private ClockHand hundredthsOfAsecond;
        private ClockHand seconds;
  

        public Timer()
        {
            this.hundredthsOfAsecond = new ClockHand(100);
            this.seconds = new ClockHand(60);
        }

        public void Advance()
        {
            this.hundredthsOfAsecond.Advance();

            if (this.hundredthsOfAsecond.value == 0)
            {
                this.seconds.Advance();
            }
        }

        public override string ToString()
        {
            return this.seconds + ":" + this.hundredthsOfAsecond;
        }
    }
}