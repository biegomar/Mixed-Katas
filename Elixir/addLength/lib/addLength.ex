defmodule AddLength do
  def add_length(str) do
    splitArray = String.split(str, [" "])
    Enum.map(splitArray, fn(x) -> x <> " " <> Integer.to_string(String.length(x)) end)    
  end
end
