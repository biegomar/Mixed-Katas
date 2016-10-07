defmodule Removenb do
  def remov_nb(n) do
    loop_nb(1, n)
  end

  def remove_nb_rec(a, b, n) when a == n do       
       if (sum_nb(n, a, b) == prod_nb(a, b)) do
           [{a, b}]
       else
           [] 
       end                
  end

  def remove_nb_rec(a, b, n) do       
       result = remove_nb_rec(a + 1, b, n)       
       if (sum_nb(n, a, b) == prod_nb(a, b)) do           
           [{a, b}] ++ result
       else
           result 
       end              
  end  

  def loop_nb(b, n) when b == n do      
      remove_nb_rec(1, b, n)
  end

  def loop_nb(b, n) do            
      result = remove_nb_rec(1, b, n)  
      IO.inspect result 
      loop_nb(b + 1, n) ++ result   
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
end
