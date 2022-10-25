namespace rt.Models
{
    public class Equifax
    {
        public Equifax(String id, int score)
        {
            this.id = id;
            this.score = score;
        }
        public String id { get; set; }
        public int? score { get; set; }
    }
}