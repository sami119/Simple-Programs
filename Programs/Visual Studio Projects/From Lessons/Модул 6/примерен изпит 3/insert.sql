insert into issues(title, issue_status, repository_id, assignee_id)
Select
	Concat('Critical Problem With ', f.name, '!') as title,
	'open' as issue_status,
    ceil(f.id*2/3) as repository_id,
	c.contributor_id as assignee_id
from files as f
Join commits as c on f.commit_id = c.id
where f.id between 46 and 50;