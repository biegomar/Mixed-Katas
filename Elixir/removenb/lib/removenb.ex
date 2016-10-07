defmodule Removenb do
  def remov_nb(n) do  
    if (n >= 1000) do
        result = Enum.sort(loop_nb(n-75, n, 45))
        IO.inspect [n, result]
        result
    else
        result = Enum.sort(loop_nb(n, n, 0))    
        IO.inspect [n, result]
        result
    end            
  end

  def remove_nb_rec(a, b, n) when a >= b do       
       if (sum_nb(n, a, b) == a * b) do
           [{a, b}, {b, a}]
       else
           [] 
       end                
  end

  def remove_nb_rec(a, b, n) do           
       result = remove_nb_rec(a + 1, b, n)       
       if (sum_nb(n, a, b) == a * b) do           
           [{a, b}, {b, a}] ++ result
       else
           result 
       end              
  end  

  def loop_nb(b, n, corr) when b <= div(n, 2) + corr do      
      remove_nb_rec(div(n,2) + corr, b, n)
  end

  def loop_nb(b, n, corr) do    
      #IO.inspect [div(n,2), b]                   
      result = remove_nb_rec(div(n,2) + corr, b, n)        
      loop_nb(b - 1, n, corr) ++ result   
  end  

  def sum_nb(n, a, b) do             
       Enum.reduce(1..n, fn(x, acc) -> x + acc end) - a - b          
  end 
end
