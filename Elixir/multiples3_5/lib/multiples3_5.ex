defmodule Multiples35 do
  def solution(number) do
    result = 0
    Enum.reduce(Enum.concat([1..number-1]), result, fn(x, acc) -> get_multiple(x) + acc end)

    #best practice
    #Enum.filter(0..number-1, fn(x) -> rem(x,3) == 0 or rem(x,5) == 0 end) |> Enum.sum
  end 

  def get_multiple(number) do
    if (rem(number, 3) == 0 or rem(number, 5) == 0) do
      number
    else
      0
    end
  end
end