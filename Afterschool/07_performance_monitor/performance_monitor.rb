
def measure n = 1
	t = 0
    n.times do
	  stime = Time.now
	  yield
	  etime = Time.now
	  t += etime - stime
	end
	t / n
end
