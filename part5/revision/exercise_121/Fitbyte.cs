namespace exercise_121
{
  public class Fitbyte
  {
       private int age;
       private int restingHeartRate;

       public Fitbyte(int age, int restingHeartRate)
       {
           this.age = age;
           this.restingHeartRate = restingHeartRate;
       }

       public double TargetHeartRate(double percentageOfMaximum)
       {
           return (206.3 - (0.711 * age) - restingHeartRate) * percentageOfMaximum + restingHeartRate; 
       } 
  }
}