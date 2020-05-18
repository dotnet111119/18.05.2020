static int Template_for_asp(Action a)
        {
            try
            {
                a.Invoke();
            }
            catch (DivideByZeroException dv)
            {
                return 400;
            }
            catch (Exception ex)
            {
                return 500;
            }
            return 200;
        }
        static int ASPNET2()
        {
            return Template_for_asp(() => { });
        }

        static int ASPNET1()
        {
            try
            {
                object facade1 = null;
                Console.WriteLine(facade1.ToString());
            }
            catch (DivideByZeroException dv)
            {
                return 400;
            }
            catch (Exception ex)
            {
                return 500;
            }
            return 200;
        }
        static void TemplateFoo(Func<int> func)
        {
            Console.WriteLine("hi");
            Console.WriteLine("good morning");
            int x = func.Invoke();
            //int x = 3 + 4;
            Console.WriteLine(x);
        }
        static void foo1()
        {
            //Console.WriteLine("hi");
            //Console.WriteLine("good morning");
            //int x = 3 + 4;
            //Console.WriteLine(x);
            TemplateFoo(() => { return 3 + 4; });
        }
        static void foo2()
        {
            Console.WriteLine("hi");
            Console.WriteLine("good morning");
            int x = 3 - 12;
            Console.WriteLine(x);
        }
        static void foo3()
        {
            Console.WriteLine("hi");
            Console.WriteLine("good morning");
            int x = 5 * 9;
            Console.WriteLine(x);
        }
