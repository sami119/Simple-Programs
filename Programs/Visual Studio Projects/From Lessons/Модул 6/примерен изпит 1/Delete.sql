Delete From colonists
	WHERE id not in (select colonist_id from travel_cards)