public int LengthOfLongestSubstring(string s) {
	var letters = new Dictionary<char, int>(); 
	int maxCount = 0, left = 0, right;

	for (right = 0; right < s?.Length; right++) {
		char letter = s[right];

		if (letters.ContainsKey(letter)) {
			left = Math.Max(left, letters[letter] + 1); 
		}

		letters[letter] = right; 

		maxCount = Math.Max(maxCount, right - left + 1); // 
	}

	return maxCount;
}
