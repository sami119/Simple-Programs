Update repositories_contributors as rc
Join 
(
	Select r.id as repo
    From repositories as r
    where r.id not in
    (
		Select repository_id
        From repositories_contributors
	)
    order by r.id
    Limit 1
)as d
Set rc.repository_id = d.repo
Where rc.contributor_id = rc.repository_id;