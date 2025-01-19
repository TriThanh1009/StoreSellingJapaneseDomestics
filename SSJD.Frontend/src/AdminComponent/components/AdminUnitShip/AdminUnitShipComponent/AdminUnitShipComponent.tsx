import React, { useEffect, useState } from "react"
import { UnitShipModel } from "../../../Model/UnitShip/UnitShipModel"
import { getUnitShip } from "../../../Responsitory/UnitShipResponsitory"



const AdminUnitShipComponent:React.FC = () =>{
    const [unitships,setUnitShips] = useState<UnitShipModel[]>()

    useEffect(()=>{
        const fetch = async () =>{
            const data = await getUnitShip()
            setUnitShips(data)
        }
        fetch()
    },[])
    return (
                    <div className="card shadow mb-4">
                        <div className="card-header py-3">
                            <h6 className="m-0 font-weight-bold text-primary">Account Table</h6>
                        </div>
                        <div className="card-body">
                            <div className="table-responsive">
                                <table className="table table-bordered" id="dataTable" width="100%" >
                                    <thead>
                                        <tr className="">
                                            <th>ID</th>
                                            <th>Name</th>

                                        </tr>
                                    </thead>

                                    <tbody>
                                    {Array.isArray(unitships) && unitships.map((unitship) => (
                                        <tr>
                                        <td>{unitship.id}</td>
                                        <td>{unitship.name}</td>
                                        </tr>
                                    ))}
                                        
                                    </tbody>
                                </table>
                            </div>
                        </div>
                    </div>

    )
}


export default AdminUnitShipComponent