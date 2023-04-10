using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueStack
{
    public class Program
    {
        static void Main(string[] args)
        {
            
        }
    }

    public class Queue<T>
    {
        List<T> queue = new List<T>();

        public int count
        {
            get => queue.Count;
        }

        /// <summary>
        /// Queue<T>의 끝 부분에 개체를 추가합니다
        /// </summary>
        /// <param name="t"></param>
        public void Enqueue(T t)
        {
            queue.Add(t);
        }

        /// <summary>
        /// Queue<T>에서 시작부분에서 개체를 제거하고 반환합니다
        /// </summary>
        /// <returns></returns>
        public T Dequeue()
        {
            

            T t = queue.First();
            queue.RemoveAt(0);

            return t;
        }

        private T First(List<T> list)
        {
            T first;
            for (int i = 0; i < list.Capacity; i++)
            {
                if (list[i] == null)
                {
                    continue;
                }
                else
                {
                    first = list[i];
                    return first;
                }
            }
            return default;
        }

        private T Last(List<T> list)
        {
            T last;
            for (int i = list.Capacity; i > length; i--)
            {

            }
        }

        /// <summary>
        /// Queue<T>에서 요소를 모두 제거합니다
        /// </summary>
        public void Clear()
        {
            //queue.Clear();
            queue.Capacity = 0;
        }

        /// <summary>
        /// Queue<T>에 T요소가 있는지 확인합니다
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public bool Contains(T t)
        {
            return queue.Contains(t);
        }

        /// <summary>
        /// Queue<T>의 첫 부분을 제거하지 않고 반환합니다
        /// </summary>
        /// <returns></returns>
        public T Peek()
        {
            T t = queue.First();
            return t;
        }
    }

    public class Stack<T>
    {
        List<T> stack = new List<T>();

        public int count
        {
            get => stack.Count;
        }

        /// <summary>
        /// 맨 위에 개체를 추가합니다
        /// </summary>
        /// <param name="t"></param>
        public void Push(T t)
        {
            stack.Add(t);
        }

        /// <summary>
        /// Stack<T>의 맨 위에서 개체를 제거하고 반환합니다
        /// </summary>
        /// <returns></returns>
        public T Pop()
        {
            T t = stack.Last();

            stack.RemoveAt(stack.Count - 1);

            return t;
        }

        /// <summary>
        /// Stack<T>의 개체를 모두 제거합니다
        /// </summary>
        public void Clear()
        {
            stack.Clear();
        }

        /// <summary>
        /// Stack<T>에 T개체가 있는지 확인합니다
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public bool Contains(T t)
        {
            return stack.Contains(t);
        }

        /// <summary>
        /// 맨 위의 개체를 제거하지 않고 반환합니다
        /// </summary>
        /// <returns></returns>
        public T Peek()
        {
            return stack.Last();
        }
    }
}
