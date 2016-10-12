defmodule MakingChangeTest do
  use ExUnit.Case
  import MakingChange

  test "some test description" do
    assert make_change(0) == %{}
    assert make_change(43) == %{D: 1, N: 1, P: 3, Q: 1}
    assert make_change(91) == %{H: 1, Q: 1, D: 1, N: 1, P: 1}
  end
end
