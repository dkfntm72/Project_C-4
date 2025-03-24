using System;
using System.Collections.Generic;
using System.Text;

namespace Project_C_4
{
    #region 클래스
    /*
    // 클래스의 시작
    class Class
    {
        static void Main(string[] args)
        {
            Person person;
            person = new Person();
            person.Name = "서준";
            person.Eat();

        }
    }
    //클래스 끝

    // 추상화 : 목적의 맞게 필요한부분만 설계하는 것

    class Person
    {
        // 속성(Property)
        public string Name;
        public string Birthday;
        public string Gender;

        // 메소드(Method)
        public void Eat()
        {
            // 먹는 행위
            Console.WriteLine(Name + "이(가) 먹습니다");
        }
        public void Walk()
        {
            // 걷는 행위
            Console.WriteLine(Name + "이(가) 걷습니다");
        }
    }
    */
    #endregion
    #region 생성자 소멸자
    /*
 class Class
 {
     static void Main(string[] args)
     {
         // 인스턴스 변수를 생성하면 생성자 호출
         Cat myCat = new Cat("코코");
         Cat myCat2 = new Cat("나비", 10);

     }
 }
 class Cat
 {
     public string Name;
     public int Weight;

     public Cat(string name)
     {
         Name = name;
         Console.WriteLine("고양이 이름은"+name+"입니다");
     }
     // 오버로딩(overloading)
     // 같은 이름의 메서드를 매개변수의 타입이나 개수를 다르게하여 중복정의 하는 것
     public Cat(string name,int weight)
     {
         Name = name;
         Weight = weight;
         Console.WriteLine("고양이 이름은" + name +"몸무게는"+weight+ "Kg 입니다");
     }
     //소멸자
     //인스턴스 변수가 메모리에서 해제될 때 호출됨
     ~Cat()
     {
         Console.WriteLine(Name + "가 사라집니다");
     }
 }
 */
    #endregion
    #region 상속
    /*
// 부모클래스의 데이터(정보)를 자직클래스에게 물려주는 것
class Robot
{
    public void Move()
    {
        Console.WriteLine("로봇이 움직입니다");
    }
}
//CleanRobot이 Robot에게 상속 받음
class CleanRobot : Robot
{
    public void Clean()
    {
        Console.WriteLine("청소를 시작합니다");
    }
}
class RescueRobot : Robot
{
    // 오버라이딩(overriding)
    // 부모클래스의 메서드를 자식클래스에서 재정의
    public void Move()
    {
        Console.WriteLine("구조 로봇이 이동합니다");
    }
}        
class Class
{
    static void Main(string[] args)
    {
        CleanRobot cr = new CleanRobot();
        RescueRobot Rr = new RescueRobot();
        cr.Move();
        cr.Clean();
        Rr.Move();
    }
}
*/
    #endregion
}
