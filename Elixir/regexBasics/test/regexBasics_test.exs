defmodule RegexBasicsTest do
  use ExUnit.Case
  import RegexBasics, only: [digit?: 1]

  test "basic cases" do
    assert digit?("7") == true  
    assert digit?("14") == false  
    assert digit?("a") == false
    assert digit?("a5") == false
    assert digit?("") == false
    assert digit?(" ") == false   
    assert digit?("1\n") == false 
  end
end
