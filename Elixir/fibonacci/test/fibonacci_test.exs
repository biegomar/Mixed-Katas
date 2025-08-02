defmodule FibonacciTest do
  use ExUnit.Case
  

  test "the truth" do
    assert Fibonacci.of(20) == 6765
  end

  test "task" do
    assert Fibonacci.with_task(20) == 6765
  end

  test "map" do
    assert Fibonacci.mapp == 6765
  end

  test "redp" do
    assert Fibonacci.redp == 6765
  end  
end
