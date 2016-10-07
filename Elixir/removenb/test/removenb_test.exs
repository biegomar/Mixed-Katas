defmodule RemovenbTest do
  use ExUnit.Case
  defp testing(_, n, ans) do 
    assert Removenb.remov_nb(n) == ans
  end
  
  test "remov_nb" do 
    testing(1, 26, [{15, 21}, {21, 15}])
    testing(2, 100, [])
    testing(3, 101, [{55, 91}, {91, 55}])
  end

  test "sum" do
    assert Removenb.sum_nb(10, 1, 2) == 52
  end

  test "filter" do
    assert Removenb.filter_nb(1..10, 2) == [1, 3, 4, 5, 6, 7, 8, 9, 10]
  end

  test "for_loop" do
    result = Removenb.loop_nb(1, 21)  
    IO.inspect result  
  end
end
