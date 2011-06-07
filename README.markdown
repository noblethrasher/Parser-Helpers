This library allow a more functional (and joyous) style of creating other types from string parsing.

* Example1 `2.Becomes("4")` creates a `ParseAttemptResult<int>` with `Value = 4` and `SuccessfulParse = true.` The string "4" is  convertible to a number.
* Example2 `(-1).Becomes("foo")` creates a `ParseAttemptResult<int>` with `Value = -1` and `SuccessfulParse = false.` The string "foo" is not convertible to a number.
* Example3 Suppse we have a method `Foo(int x)`; We can call it with `Foo( 2.Becomes(str) )`