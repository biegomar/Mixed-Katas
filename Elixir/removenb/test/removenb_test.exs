defmodule RemovenbTest do
  use ExUnit.Case
  defp testing(_, n, ans) do 
    assert Removenb.remov_nb(n) == ans
  end
  
  test "remov_nb" do 
    testing(1, 26, [{15, 21}, {21, 15}])
    testing(2, 100, [])
    testing(3, 101, [{55, 91}, {91, 55}])
    testing(4, 102, [{70, 73}, {73, 70}])
    testing(5, 110, [{70, 85}, {85, 70}])
    testing(6, 1006, [{546, 925}, {925, 546}])
  end  
end
