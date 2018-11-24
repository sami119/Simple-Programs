DELETE r 
FROM repositories AS r
LEFT JOIN issues AS i ON r.id = i.repository_id 
WHERE i.id IS NULL;