defmodule Multiples35Test do
  use ExUnit.Case
  

  test "the truth" do
    assert Multiples35.solution(10) == 23
  end

  test "multiple" do
    assert Multiples35.get_multiple(3) == 3
  end
end
