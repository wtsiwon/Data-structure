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
            int[] datas = new int[15];
            for (int i = 0; i < datas.Length; i++)
			{
                int random = Random.Next(0, 100);
                datas[i] = Random.Next(0, 100);

			}

        }

        static void QuickSort(int[] datas)
        {
            int left = 0;//왼쪽 끝 index
            int right = datas.Length - 1;//오른쪽 끝 index

            int pivot = (left + right) / 2;

            //pivot을 기준으로 정렬

            
            
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

        private void Add(T item)
        {
            if(count == queue.Capacity)
            {
                EnsureCapacity();
            }
        }

        private void EnsureCapacity()
        {

        }

        /// <summary>
        /// Queue<T>에서 시작부분에서 개체를 제거하고 반환합니다
        /// </summary>
        /// <returns></returns>
        public T Dequeue()
        {
            T t = First(queue);
            RemoveAt(0);
            return t;
        }

        private void RemoveAt(int index)
        {
            Array.Copy(queue, index + 1, queue, index, queue.Capacity - index);
            queue[queue.Count - 1] = default;
        }

        private T First()
        {
            T first;
            if (queue.Count > 0)
            {
                first = queue[0];
                return first;
            }
            else
            {
                throw new NullReferenceException();
            }
        }

        private T Last()
        {
            T last;
            if (queue != null)
            {
                last = queue[queue.Count - 1];
                return last;
            }
            else
            {
                throw new NullReferenceException();
            }
        }

        /// <summary>
        /// Queue<T>에서 요소를 모두 제거합니다
        /// </summary>
        public void Clear()
        {
            //queue.Clear();
            for (int i = 0; i < queue.Count; i++)
            {
                queue[i] = default;
            }
        }

        /// <summary>
        /// Queue<T>에 T요소가 있는지 확인합니다
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public bool Contains(T t)
        {
            for (int i = 0; i < queue.Count; i++)
			{
                if (queue[i] == t)
                {
                    return true;
                }
			}
            return false;
        }

        /// <summary>
        /// Queue<T>의 첫 부분을 제거하지 않고 반환합니다
        /// </summary>
        /// <returns></returns>
        public T Peek()
        {
            T t = First();
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
