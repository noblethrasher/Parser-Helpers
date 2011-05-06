using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prelude
{
    public struct ParseAttemptResult<T>
    {
        public T Value { get; private set; }
        public bool SuccessfulParse { get; private set; }
        
        public ParseAttemptResult(T Value, bool SuccessfulParse) : this()
        {
            this.Value = Value;
            this.SuccessfulParse = SuccessfulParse;
        }

        //We override the true and false operators because we want to use this in branching statements; e.g. if, while, and the ternary operator.
        //Normally we would want to just implicitly cast to bool but that doesn't work since T might be a bool resulting in an ambiguity error.

        public static bool operator true(ParseAttemptResult<T> obj)
        {
            return obj.SuccessfulParse;
        }

        public static bool operator false(ParseAttemptResult<T> obj)
        {
            return obj.SuccessfulParse;
        }

        public static implicit operator T(ParseAttemptResult<T> obj)
        {
            return obj.Value;
        }

        public override string ToString()
        {
            return Value.ToString ();
        }

    }

    public static class ParseUtils
    {

        //These methods allow a more functional style of creating other types from string parsing.

        //Example1 2.Becomes("4") creates a ParseAttemptResult<int> with Value = 4 and SuccessfulParse = true.
        //Example2 (-1).Becomes("foo") creates a ParseAttemptResult<int> with Value = -1 and SuccessfulParse = false.
        //Example3 Suppse we have a method Foo(int x); We can call it with Foo( 2.Becomes(str) )

        public static ParseAttemptResult<Boolean> Becomes(this Boolean n, string s)
        {
            var result = Boolean.TryParse (s, out n);

            return new ParseAttemptResult<Boolean> (n, result);
        }



        public static ParseAttemptResult<Int16> Becomes(this Int16 n, string s)
        {
            var result = Int16.TryParse (s, out n);

            return new ParseAttemptResult<Int16> (n, result);
        }



        public static ParseAttemptResult<Int32> Becomes(this Int32 n, string s)
        {
            var result = Int32.TryParse (s, out n);

            return new ParseAttemptResult<Int32> (n, result);
        }



        public static ParseAttemptResult<Int64> Becomes(this Int64 n, string s)
        {
            var result = Int64.TryParse (s, out n);

            return new ParseAttemptResult<Int64> (n, result);
        }



        public static ParseAttemptResult<UInt16> Becomes(this UInt16 n, string s)
        {
            var result = UInt16.TryParse (s, out n);

            return new ParseAttemptResult<UInt16> (n, result);
        }



        public static ParseAttemptResult<UInt32> Becomes(this UInt32 n, string s)
        {
            var result = UInt32.TryParse (s, out n);

            return new ParseAttemptResult<UInt32> (n, result);
        }



        public static ParseAttemptResult<UInt64> Becomes(this UInt64 n, string s)
        {
            var result = UInt64.TryParse (s, out n);

            return new ParseAttemptResult<UInt64> (n, result);
        }



        public static ParseAttemptResult<Double> Becomes(this Double n, string s)
        {
            var result = Double.TryParse (s, out n);

            return new ParseAttemptResult<Double> (n, result);
        }



        public static ParseAttemptResult<Decimal> Becomes(this Decimal n, string s)
        {
            var result = Decimal.TryParse (s, out n);

            return new ParseAttemptResult<Decimal> (n, result);
        }



        public static ParseAttemptResult<Single> Becomes(this Single n, string s)
        {
            var result = Single.TryParse (s, out n);

            return new ParseAttemptResult<Single> (n, result);
        }



        public static ParseAttemptResult<DateTime> Becomes(this DateTime n, string s)
        {
            DateTime whenever;
            
            var result = DateTime.TryParse (s, out whenever);

            return new ParseAttemptResult<DateTime> (result ? whenever : n, result);
        }
    


    }
}
