defmodule TestStringUtils do
  use ExUnit.Case
  import StringUtils, only: [upper_case?: 1]

  test "basic cases from description" do
    assert upper_case?("") == true
    assert upper_case?("c") == false
    assert upper_case?("C") == true
    assert upper_case?("hello I AM DONALD") == false
    assert upper_case?("HELLO I AM DONALD") == true
    assert upper_case?("ACSKLDFJSgSKLDFJSKLDFJ") == false
    assert upper_case?("ACSKLDFJSGSKLDFJSKLDFJ") == true    
  end
end