namespace OOP
{
    public class Character
    {
        public int level {  get; set; }
        public int hp {  get; set; }
        public float speed {  get; set; }
        public int attackPower {  get; set; }
        public string moveDirection { get; set; } = "forword";
        
        public Character(int level, int hp, float speed, int attackPower)
        {
            Console.WriteLine($"캐릭터의 레벨은 {level}이고, 체력은 {hp}, 이동속도는 {speed}, 공격력은 {attackPower}입니다.");
        }

        public void MoveFoward()
        {
            Console.WriteLine("전진");
        }
        public void MoveBack()
        {
            Console.WriteLine("후진");
        }
        public void MoveLeft()
        {
            Console.WriteLine("좌회전(90도)");
        }
        public void MoveRight()
        {
            Console.WriteLine("우회전(90도)");
        }
        public void Attack()
        {
            Console.WriteLine("공격");
        }
        public void GetHit()
        {
            Console.WriteLine("피격");
        }
    }
    internal class Program
    {
              
        static void Main(string[] args)
        {
            Console.WriteLine("클래스 선언하기\n==========");
            Character character = new Character(1, 100,120,50);
            character.MoveFoward();
            character.MoveBack();
            character.MoveLeft();
            character.MoveRight();
            character.Attack();
            character.GetHit();
        }

    }
}
