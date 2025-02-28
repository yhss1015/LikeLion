using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miniInventory
{
    internal class Program
    {

        struct Inventory
        {
            public string[] itemNames;
            public int[] itemCounts;

            //  생성자를 추가하여 배열 초기화
            public Inventory(int maxItems)
            {
                itemNames = new string[maxItems];
                itemCounts = new int[maxItems];
            }
        }


        // 최대 아이템 보관 개수 (배열 크기)
        const int MAX_ITEMS = 10;
        
        static Inventory inven = new Inventory(MAX_ITEMS);


        // 아이템 추가 함수
        static void ADDItem(string name, int count)
        {
            for (int i = 0; i < MAX_ITEMS; i++)
            {
                if(inven.itemNames[i] == name) //이미 있는 아이템은 개수 증가
                {
                    inven.itemCounts[i]+=count;
                    return;
                }
            }

            for (int i = 0; i < MAX_ITEMS; i++)
            {
                if (inven.itemNames[i]==null)
                {
                    inven.itemNames[i] = name;
                    inven.itemCounts[i] = count;
                    return;
                }
            }

            Console.WriteLine("인벤토리가 가득 찼습니다.");
        }


        //아이템 제거 함수
        static void RemoveItem(string name, int count)
        {
            for (int i = 0; i < MAX_ITEMS; i++)
            {
                if (inven.itemNames[i] == name) // 이름이 같은가
                {
                    if (inven.itemCounts[i] >=count) // 차감가능한가
                    {
                        inven.itemCounts[i] -= count;
                        if(inven.itemCounts[i] ==0) // 개수 0이면 삭제
                        {
                            inven.itemNames[i]=null;
                        }
                        return;
                    }
                    else
                    {
                        Console.WriteLine("아이템 개수가 부족합니다.");
                        return;
                    }
                }
            }
            Console.WriteLine("아이템을 찾을 수 없습니다.");
        }

        //인벤토리 출력 함수
        static void ShowInventory()
        {
            Console.WriteLine("현재 인벤토리 : ");
            bool isEmpty = true;

            for (int i = 0; i < MAX_ITEMS; i++)
            {
                if (inven.itemNames[i] != null)
                {
                    Console.WriteLine($"{inven.itemNames[i]} (x{inven.itemCounts[i]})");
                    isEmpty = false;
                }
            }
            if(isEmpty)
            {
                Console.WriteLine("인벤토리가 비어 있습니다.");
            }
        }


        static void Main(string[] args)
        {
            

            //테스트 아이템 추가
            ADDItem("칼", 1);
            ADDItem("포션", 3);
            ADDItem("포션", 5);
            ShowInventory();

            // 아이템 사용
            Console.WriteLine("\n포션 2개 사용\n");
            RemoveItem("포션", 2);
            ShowInventory();

            // 없는 아이템 사용시도
            Console.WriteLine("\n방패 1개 제거 시도\n");
            RemoveItem("방패", 1);
            ShowInventory();

            // 아이템 개수 모두 소진하기
            Console.WriteLine("\n포션 6개 모두 사용\n");
            RemoveItem("포션", 6);
            ShowInventory();


        }
    }
}
