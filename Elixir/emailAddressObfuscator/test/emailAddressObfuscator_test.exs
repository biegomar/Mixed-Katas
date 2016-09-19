defmodule EmailAddressObfuscatorTest do
  use ExUnit.Case

  test "swaps the at character" do
    result = EmailAddressObfuscator.execute("sample@example.com")
    assert result == "sample [at] example [dot] com"
  end

  test "two dots in the name" do
    result = EmailAddressObfuscator.execute("jim.kuback@ennerman-hatano.com")
    assert result == "jim [dot] kuback [at] ennerman-hatano [dot] com"
  end
end
