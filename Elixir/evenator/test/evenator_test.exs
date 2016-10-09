defmodule EvenatorTest do
  use ExUnit.Case
  import Evenator

  test "basic cases" do
    assert even?(0) == true
    assert even?(0.5) == false
    assert even?(1) == false
    assert even?(2) == true
    assert even?(-4) == true
  end
end
