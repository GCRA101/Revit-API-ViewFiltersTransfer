
public class ModifyObjGroupAssign : ModifyBehaviour
{
    /* ATTRIBUTES */
    private string objName;
    private ObjectType objType;
    private string groupName;

    /* CONSTRUCTORS */
    // Default
    public ModifyObjGroupAssign(ETABSv1.cSapModel etabsModel) : base(etabsModel){}
    // Overloaded
    public ModifyObjGroupAssign(ETABSv1.cSapModel etabsModel, string objName, ObjectType objType, string groupName) :base(etabsModel)
    { 
        this.objName= objName;
        this.objType = objType;
        this.groupName = groupName;
    }

    /* METHODS */

    // Setters
    public void setObjName(string objName) { this.objName=objName; }
    public void setObjType(ObjectType objType) { this.objType = objType; }
    public void setGroupName(string groupName) { this.groupName = groupName;}

    // Getters
    public string getObjName() { return this.objName; }
    public ObjectType getObjType() { return this.objType; }
    public string getGroupName() { return this.groupName; }


    public void modify()
    {
        switch (this.objType) {
            case ObjectType.POINT: this.etabsModel.PointObj.SetGroupAssign(objName, groupName); break;
            case ObjectType.FRAME: this.etabsModel.FrameObj.SetGroupAssign(objName, groupName); break;
            case ObjectType.AREA: this.etabsModel.AreaObj.SetGroupAssign(objName, groupName); break;
            case ObjectType.TENDON: this.etabsModel.TendonObj.SetGroupAssign(objName, groupName); break;
            default: break;
        }


    }




}
