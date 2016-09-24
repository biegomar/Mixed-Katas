defmodule AddLengthTest do
  use ExUnit.Case
  import AddLength

  test "basic tests" do
    assert add_length("apple ban") == ["apple 5", "ban 3"]
    assert add_length("you will win") == ["you 3", "will 4", "win 3"]
    assert add_length("you") == ["you 3"]
    assert add_length("y") == ["y 1"]    
  end
end
