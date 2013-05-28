def reverser &result
	result.call.split.map{|w| w.reverse}.join(' ')
end

def adder n = 1, &result
	n + result.call
end

def repeater n = 1, &result
	n.times{result.call}
end
