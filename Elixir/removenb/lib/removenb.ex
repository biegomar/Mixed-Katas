defmodule Removenb do
  def remov_nb(n) do    
    IO.puts "n is #{n}"
    short_n = div(n,2)    
    result = Enum.reduce(Enum.to_list(n..1), [], fn(x, acc) -> remove_nb_rec(short_n, x, n, sum_nb(n, short_n, x)) ++ acc end)    
    IO.inspect [n, result]
    result           
  end

  def remove_nb_rec(a, b, _, sum) when sum <= a * b or a >= b do              
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
     n * (n+1) / 2 - a - b
  end
end
