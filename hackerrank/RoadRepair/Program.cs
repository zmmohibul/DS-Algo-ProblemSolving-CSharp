long getMinCost(List<int> crew_id, List<int> job_id)
{

    long answer = 0;

    crew_id.Sort();
    job_id.Sort();


    for (int i = 0; i < crew_id.Count; i++) 
    {
        if (crew_id[i] > job_id[i]) 
        {
            answer += crew_id[i] - job_id[i];
        }
        else 
        {
            answer += job_id[i] - crew_id[i];
        }
    }


    return answer;

}