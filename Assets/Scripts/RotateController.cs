using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
struct Rotate
{
    public Rotating rotating;
    public int id;

    public Rotate(Rotating rotating,int id)
    {
        this.rotating = rotating;
        this.id = id;
    }
}

public class RotateController
{

    private static RotateController _instance = null;
    private ArrayList rotatings;
    private int selectedId = 1;
    private int maxId = 1;

    private RotateController()
    {
        rotatings = new ArrayList();
    }

    public static RotateController getInstance()
    {
        if (_instance == null)
        {
            _instance = new RotateController();
        }
        return _instance;
    }

    public void addRotating(Rotating r,int id)
    {
        Rotate rotate = new Rotate(r, id);
        if (rotatings.Contains(rotate))
        {
            return;
        }
        else
        {
            rotatings.Add(rotate);
            if (id > maxId)
            {
                maxId = id;
            }
        }
    }

    public void removeRotating(Rotating r, int id)
    {
        Rotate rotate = new Rotate(r, id);
        if (rotatings.Contains(rotate))
        {
            rotatings.Remove(rotate);
        }
    }

    public void clearRotatings()
    {
        rotatings.Clear();
        selectedId = 1;
        maxId = 1;
}

    public void select()
    {
        foreach(Rotate r in rotatings)
        {
            if(r.id==selectedId)
            {
                r.rotating.changeSelect(true);
            }
            else
            {
                r.rotating.changeSelect(false);
            }
        }
    }
    public void selectNext()
    {
        if (selectedId < maxId)
        {
            selectedId += 1;
        }
        else
        {
            selectedId = 1;
        }
        select();
    }

    public void selectPre()
    {
        if (selectedId > 1)
        {
            selectedId -= 1;
        }
        else
        {
            selectedId = maxId;
        }
        select();
    }

    public ArrayList getRotatingGroup(int id)
    {
        ArrayList result = new ArrayList();
        foreach(Rotate r in rotatings)
        {
            if (r.id == id)
            {
                result.Add(r.rotating);
            }
        }
        return result;
    }
}
