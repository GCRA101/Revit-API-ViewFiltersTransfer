
public abstract class ModifyBehaviour : ModifyData {
	
	/* ATTRIBUTES */
	protected int ret;
	protected ETABSv1.cSapModel etabsModel;
	
	/* CONSTRUCTORS */
	//Default
	public ModifyBehaviour(ETABSv1.cSapModel etabsModel) {
		this.etabsModel=etabsModel;
	}
	
	/* METHODS */
	public void modify() {}

}
