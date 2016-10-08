defmodule Removenb do
  def remov_nb(n) do    
    short_n = div(n,2)    
    result = Enum.reduce(Enum.concat([n..1]), [], fn(x, acc) -> remove_nb_rec(short_n, x, n, sum_nb(n, short_n, x)) ++ acc end)     
    |> Enum.sort
    IO.inspect [n, result]
    result           
  end

  def remove_nb_rec(a, b, n, sum) when a >= b or sum <= a * b do              
       if (sum == a * b) do           
           [{a, b}, {b, a}]
       else
           [] 
       end                    
  end

  def remove_nb_rec(a, b, n, sum) do                
       result = remove_nb_rec(a + 1, b, n, sum_nb(n, a+1, b))       
       if (sum == a * b) do           
           [{a, b}, {b, a}] ++ result           
       else
           result 
       end              
  end  

  def sum_nb(n, a, b) do             
       Enum.reduce(1..n, fn(x, acc) -> x + acc end) - a - b          
  end     
end
