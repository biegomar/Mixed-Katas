defmodule PriceOfMangoesTest do
  use ExUnit.Case
  import PriceOfMangoes

  test "Basic Tests" do
    assert mango(3, 3) == 6
    assert mango(9, 5) == 30
    assert mango(0, 5) == 0
    assert mango(9, 0) == 0
    assert mango(7541, 424) == 2131872
  end
end
