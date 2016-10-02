defmodule Removenb do
  def remov_nb(n) do
    # your code
  end

  def sum_nb(n, a, b) do      
       filter_nb(1..n, a) |> filter_nb(b) |> Enum.reduce(fn(x, acc) -> x + acc end)           
  end 

  def prod_nb(a, b) do
      a * b
  end 

  def filter_nb(list, a) do
      Enum.filter(list, fn(x) -> x != a end)
  end

  def filter_list(list, sublist) do
      list -- sublist
  end
    
  def double_loop(n) do
      Enum.reduce(1..n, fn(x, acc) -> Enum.reduce(1..n, x, fn(y, acc) ->           
          IO.puts(x)
          IO.puts(y)
          IO.puts(x*y) 
        end) end)
  end
end
