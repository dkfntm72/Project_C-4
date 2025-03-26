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
    #region foreach
    // foreach(선언식 in 배열변수명)
    /*
    class Class
    {
        static void Main(string[] args)
        {
            int[] arr=new int[] { 1,2,3}; //배열 선언

            foreach(int i in arr) //배열을 순회
            {
                Console.WriteLine(i);
            }
        }
    }
    */
    #endregion
    #region 예외처리
    //예외 상황이 발생하는 영역을 묶어 비정상적인 종료가 되지 않도록 방지
    /*
   class Class
   {
       static void Main(string[] args)
       {
           Console.Write("나눌 숫자를 입력하세요");
           int divider = int.Parse(Console.ReadLine());
           try
           {
               Console.WriteLine(10 / divider);
           }
           catch
           {
               Console.WriteLine("0으로 나눌 수 없습니다");
           }

       }
   }
     */

    #endregion
    #region 제네릭
    // Generic : 일반화
    // 서로다른 개념을 하나의 공통된 개념으로 묶는 것

    // 일반화 프로그래밍
    // 서로 다른 데이터 형식을 하나의 데이터 형식으로 묶는 것

    // template
    //함수 내의 데이터 형식을 함수 호출부분에서 정의

    // 제네릭 클래스
    /*
    public class GenericClass<T>
    {
        private T data;
        public void SetData(T value)
        {
            data = value;
        }
        public T GetData()
        {
            return data;
        }
    }

    // 제네릭 함수
    public class GenericMethodClass
    {
        public void Print<T>(T input)
        {
            Console.WriteLine(input);
        }
    }
    class Class
    {

        static void Main(string[] args)
        {
            GenericClass<int> intObj = new GenericClass<int>();
            intObj.SetData(100);
            Console.WriteLine(intObj.GetData());

            GenericMethodClass obj = new GenericMethodClass();
            obj.Print(10);       
            obj.Print("World");  
            obj.Print(3.14);     
        }
    }
    */
    #endregion
    #region 인터페이스
    // 인터페이스는 클래스나 구조체가 반드시 구현해야 하는 메서드, 속성, 이벤트등의 규격을 정의하는 기능이다
    // 인터페이스는 상호간 약속

    // 인터페이스 사용 규칙
    // 1. 인터페이스는 메소드 이벤트 인덱서 프로퍼티만 가질 수 있다
    // 2. 접근제한 한정자를 사용할 수 없고 모든 것이 public으로 선언해야한다
    // 3. 인터페이스는 자신을 상속받은 클래스에게 오버라이딩을 강제한다(인터페이스를 상속받은 클래스는 반드시 모든 요소를 재정의 해야한다.)
    // 4. 인터페이스는 인스턴스를 만들 수 없지만, 인터페이스를상속받은 클래스의 인스턴스를 만드닌것은 가능하다.(어찌보면 당연한)
    // 5. 클래스는 여러 인터페이스를 상속 받는 것이 가능하다.
    // 6. 구현부가 없다

    // interface 인터페이스이름
    // {
    //    반환형 메소드이름1(메개변수목록);
    //    반환형 메소드이름2(메개변수목록);
    // }
    interface Promise
    {
        void Print(string message);
    }
    interface Promise2
    {
        void IntPrint(int num);
    }
    public class ExClass : Promise
    {
        // Print 함수를 재정의
        public void Print(string message)
        {
            Console.WriteLine(message);
        }
    }
    public class ExClass2 : Promise
    {
        // Print 함수를 재정의하지 않으면 오류남
    }
    
    public class ExClass3 : Promise,Promise2
    {
        // 상속받은 모든 인터페이스의 메서드를 재정의 해야함
        public  void Print(string message)
        {
            Console.WriteLine(message);
        }
        public void IntPrint(int num)
        {
            Console.WriteLine(num);
        }
    }
    class Class
    {

        static void Main(string[] args)
        {
            ExClass exClass = new ExClass();
            ExClass3 exClass3 = new ExClass3();
            exClass.Print("HelloWorld");
            exClass3.Print("Hi");
            exClass3.IntPrint(10);
        }
    }
    #endregion
}
